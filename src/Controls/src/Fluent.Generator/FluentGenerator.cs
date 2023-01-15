using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.Maui.Controls.Fluent.Generator
{
	public class FluentGenerator
	{
		public const string FluentInterfaceAttributeString = "FluentInterfaceAttribute";
		public const string ContentPropertyAttributeString = "ContentPropertyAttribute";
		public const string BindablePropertiesAttributeString = "BindablePropertiesAttribute";

		GeneratorExecutionContext context;

		public static string[] notGenerateList = { "this[]", "Handler", "LogicalChildren" };

		public FluentGenerator(GeneratorExecutionContext context)
		{
			this.context = context;
		}

		public bool IsPublicBindableObjectWithConstructor(ISymbol symbol)
		{
			bool isViewObject = false;
			var namedSymbol = symbol as INamedTypeSymbol;

			if (namedSymbol != null &&
				namedSymbol.TypeKind == TypeKind.Class &&
				!namedSymbol.IsGenericType &&
				!namedSymbol.IsAbstract &&
				namedSymbol.DeclaredAccessibility == Accessibility.Public &&
				namedSymbol.ToDisplayString().StartsWith("Microsoft.Maui.Controls") &&
				namedSymbol.Constructors.FirstOrDefault(e => e.DeclaredAccessibility == Accessibility.Public) != null &&
				namedSymbol.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Equals("ObsoleteAttribute", StringComparison.Ordinal)) == null)
			{

				Helpers.LoopDownToObject(namedSymbol, type =>
				{
					isViewObject = type.ToDisplayString().Equals("Microsoft.Maui.Controls.BindableObject", StringComparison.Ordinal);
					return isViewObject;
				});
			}
			return isViewObject;
		}

		public static bool IsFluentObject(ISymbol symbol)
		{
			var namedSymbol = symbol as INamedTypeSymbol;
			if (namedSymbol != null)
			{
				var attributes = symbol.GetAttributes();
				return attributes.FirstOrDefault(e => e.AttributeClass.Name.Equals(FluentInterfaceAttributeString, StringComparison.Ordinal)) != null;
			}
			return false;
		}

		public static bool HasContentPropertyAttribute(ISymbol symbol)
		{
			var namedSymbol = symbol as INamedTypeSymbol;
			if (namedSymbol != null)
			{
				var attributes = symbol.GetAttributes();
				return attributes.FirstOrDefault(e => e.AttributeClass.Name.Equals(ContentPropertyAttributeString, StringComparison.Ordinal)) != null;
			}
			return false;
		}

		public static IPropertySymbol FindPropertySymbolWithName(INamedTypeSymbol symbol, string propertyName)
		{
			IPropertySymbol propertySymbol = null;
			Helpers.LoopDownToObject(symbol, type =>
			{
				propertySymbol = (IPropertySymbol)(type.GetMembers(propertyName).FirstOrDefault());
				return propertySymbol != null;
			});
			return propertySymbol;
		}

		public static string GetContentPropertyName(INamedTypeSymbol symbol)
		{
			var attributeData = symbol.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Equals(ContentPropertyAttributeString, StringComparison.Ordinal));
			return attributeData != null ? (string)attributeData.ConstructorArguments[0].Value : null;
		}

		public static bool IsNewContainer(INamedTypeSymbol symbol)
		{
			bool isNewContainer = false;
			Helpers.LoopDownToObject(symbol.BaseType, type =>
			{
				isNewContainer = type.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Equals(ContentPropertyAttributeString, StringComparison.Ordinal)) != null;
				return isNewContainer;
			});
			return isNewContainer;
		}

		

		List<INamedTypeSymbol> symbolsWithAttribute;
		List<INamedTypeSymbol> mauiSymbols;
		List<INamedTypeSymbol> symbolsToGenerate;
		List<INamedTypeSymbol> parentSymbols;

		void GenerateSymbolLists()
		{
			mauiSymbols = context.Compilation.GetSymbolsWithName((s) => true, filter: SymbolFilter.Type)
				.Where(IsPublicBindableObjectWithConstructor).Select(e => (INamedTypeSymbol)e).ToList();

			symbolsWithAttribute = context.Compilation.GetSymbolsWithName((s) => true, filter: SymbolFilter.Type)
				.Where(IsFluentObject).Select(e => (INamedTypeSymbol)e).ToList();

			symbolsToGenerate = new List<INamedTypeSymbol>();
			symbolsToGenerate.AddRange(mauiSymbols);
			foreach (var symbol in symbolsWithAttribute)
				if (!symbolsToGenerate.Contains(symbol)) symbolsToGenerate.Add(symbol);

			parentSymbols = new List<INamedTypeSymbol>();
			foreach (var symbol in symbolsToGenerate)
			{
				Helpers.LoopDownToObject(symbol.BaseType, type =>
				{
					if (IsFluentObject(type) && !type.IsGenericType) return true;
					if (!parentSymbols.Contains(type) && !symbolsToGenerate.Contains(type))
						parentSymbols.Add(type);
					return false;
				});
			}

			var allSymbols = new List<INamedTypeSymbol>();
			allSymbols.AddRange(symbolsToGenerate);
			allSymbols.AddRange(parentSymbols);
			var sealedSymbols = allSymbols.Where(e => e.IsSealed).ToList();
			sealedSymbols.Sort((a, b) => a.ToDisplayString().CompareTo(b.ToDisplayString()));

			GenerateInfoFile(sealedSymbols, "_sealedSymbols.g.cs", true);
		}

		class NamedTypeSymbolComparer : IEqualityComparer<INamedTypeSymbol>
		{
			public bool Equals(INamedTypeSymbol b1, INamedTypeSymbol b2)
			{
				if (b1 == null && b2 == null)
					return true;
				else if (b1 == null || b2 == null)
					return false;

				return b1.ToDisplayString().Equals(b2.ToDisplayString(), StringComparison.Ordinal);
			}

			public int GetHashCode(INamedTypeSymbol bx)
			{
				return bx.ToDisplayString().GetHashCode();
			}
		}

		void GenerateClassesWithContentPropertyAttribute()
		{
			var all = context.Compilation.GetSymbolsWithName((s) => true, filter: SymbolFilter.Type)
				.Where(HasContentPropertyAttribute).Select(e => (INamedTypeSymbol)e).ToList();

			all.Sort((a, b) => a.ToDisplayString().CompareTo(b.ToDisplayString()));

			var generic = all.Where(e => Helpers.IsGenericIList(e, out _));
			var redefined = all.Where(IsNewContainer).ToList();

			var notGenerate = generic.Union(redefined, SymbolEqualityComparer.Default);

			var rest = all.Except(generic).Except(redefined);

			var ilistcontent = rest.Where(e =>
			{
				var propertyName = GetContentPropertyName(e);
				var propertyType = FindPropertySymbolWithName(e, propertyName);
				return !IsNewContainer(e) && Helpers.IsGenericIList((INamedTypeSymbol)propertyType.Type, out _);
			}).ToList();
			var ienumerablecontainer = rest.Except(ilistcontent);

			GenerateClassesWithContentFile(all, "__1_all.g.cs");
			GenerateClassesWithContentFile(generic, "__2a_generic.g.cs");
			GenerateClassesWithContentFile(redefined, "__2b_redefined.g.cs");
			GenerateClassesWithContentFile(notGenerate, "__3_notGenerate.g.cs");
			GenerateClassesWithContentFile(rest, "__4_rest.g.cs");
			GenerateClassesWithContentFile(ilistcontent, "__5_ilistcontent.g.cs", ilist: true);
			GenerateClassesWithContentFile(ienumerablecontainer, "__6_ienumerablecontainer.g.cs", single: true);
		}

		void GenerateClassesWithContentFile(IEnumerable<ISymbol> symbols, string fileName, bool single = false, bool ilist = false)
		{
			var builder = new StringBuilder();
			builder.AppendLine("//");
			builder.AppendLine("// <auto-generated>");
			builder.AppendLine("//");
			builder.AppendLine("/*");
			builder.AppendLine();


			builder.AppendLine();
			builder.AppendLine($"Count {symbols.Count()}");
			builder.AppendLine();

			foreach (var symbol in symbols)
				builder.AppendLine($"{symbol.ToDisplayString()}");


			if (single)
			{
				foreach (var symbol in symbols)
				{
					var typedSymbol = (INamedTypeSymbol)symbol;
					var propertyName = GetContentPropertyName(typedSymbol);
					var propertyType = FindPropertySymbolWithName(typedSymbol, propertyName);
					builder.AppendLine($@"
// ------- {symbol.ToDisplayString()} -------

public IEnumerator GetEnumerator()
{{
	yield return this.{propertyName};
}}

public void Add({propertyType.Type.Name} {Helpers.CamelCase(propertyName)})
	=> this.{propertyName} = {Helpers.CamelCase(propertyName)};
");
				}
			}

			if (ilist)
			{
				foreach (var symbol in symbols)
				{
					var typedSymbol = (INamedTypeSymbol)symbol;
					var propertyName = GetContentPropertyName(typedSymbol);
					var propertyType = FindPropertySymbolWithName(typedSymbol, propertyName);
					Helpers.IsGenericIList((INamedTypeSymbol)propertyType.Type, out var itemType);
					builder.AppendLine($@"
// ------- {symbol.ToDisplayString()} -------

public IEnumerator GetEnumerator()
	=> this.{propertyName}.GetEnumerator();

public void Add({itemType.Name} {Helpers.CamelCase(propertyName)})
	=> this.{propertyName}.Add({Helpers.CamelCase(propertyName)});
");
				}
			}

			builder.AppendLine();

			builder.AppendLine();
			builder.AppendLine("*/");

			context.AddSource(fileName, builder.ToString());
		}


		void ListSymbols()
		{
			mauiSymbols.Sort((a, b) => a.ToDisplayString().CompareTo(b.ToDisplayString()));
			symbolsToGenerate.Sort((a, b) => a.ToDisplayString().CompareTo(b.ToDisplayString()));
			symbolsWithAttribute.Sort((a, b) => a.ToDisplayString().CompareTo(b.ToDisplayString()));
			parentSymbols.Sort((a, b) => a.ToDisplayString().CompareTo(b.ToDisplayString()));

			GenerateInfoFile(mauiSymbols, "_mauiSymbols.g.cs");
			GenerateInfoFile(symbolsWithAttribute, "_symbolsWithAttribute.g.cs");
			GenerateInfoFile(symbolsToGenerate, "_symbolsToGenerate.g.cs");
			GenerateInfoFile(parentSymbols, "_parentSymbols.g.cs");
		}

		public void Generate()
		{
			GenerateSymbolLists();
			GenerateClassesWithContentPropertyAttribute();
			ListSymbols();

			foreach (var symbol in symbolsToGenerate)
			{
				new ClassGenerator(context, symbol).Build();
				if (!symbol.IsGenericType)
					new ExtensionGenerator(context, symbol).Build();
			}
			foreach (var symbol in parentSymbols)
			{
				new ExtensionGenerator(context, symbol).Build();
			}
		}

		void GenerateInfoFile(IEnumerable<ISymbol> symbols, string fileName, bool regExp = false)
		{
			var builder = new StringBuilder();
			builder.AppendLine("//");
			builder.AppendLine("// <auto-generated>");
			builder.AppendLine("//");
			builder.AppendLine("/*");
			builder.AppendLine();
			if (regExp)
			{
				builder.Append("public (sealed class |sealed partial class )(");
				var first = true;
				foreach (var symbol in symbols)
				{
					builder.Append($"{(first ? "" : "|")}{symbol.Name}");
					first = false;
				}
				builder.AppendLine(")( |\\n)");
			}

			builder.AppendLine();
			builder.AppendLine($"Count {symbols.Count()}");
			builder.AppendLine();

			foreach (var symbol in symbols)
				builder.AppendLine($"{symbol.ToDisplayString()}");

			builder.AppendLine();
			builder.AppendLine("*/");

			context.AddSource(fileName, builder.ToString());
		}
	}
}