using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;


namespace Microsoft.Maui.Controls.Fluent.Generator
{
	public static class Helpers
	{
		static string[] keywords = { "class", "switch", "event" };

		public static void WaitForDebugger(CancellationToken cancellationToken)
		{
#if DEBUG
			while (!Debugger.IsAttached && !cancellationToken.IsCancellationRequested)
				Task.Delay(1000).Wait(cancellationToken);
#endif
		}

		public static string CamelCase(string str)
		{
			var camelCaseName = $"{str.Substring(0, 1).ToLower()}{str.Substring(1)}";
			if (keywords.Contains(camelCaseName)) camelCaseName = $"@{camelCaseName}";
			return camelCaseName;
		}

		public static void LoopDownToObject(INamedTypeSymbol symbol, Func<INamedTypeSymbol, bool> func)
		{
			var type = symbol;
			var endLoop = false;
			while (!endLoop && type != null && !type.Name.Equals("Object", StringComparison.Ordinal))
			{
				endLoop = func(type);
				type = type.BaseType;
			}
		}

		public static bool IsGenericIList(INamedTypeSymbol symbol, out ITypeSymbol elementType)
		{
			if (symbol.Name.Equals("IList", StringComparison.Ordinal) && symbol.IsGenericType)
			{
				elementType = symbol.TypeArguments.First();
				return true;
			}

			ITypeSymbol _elementType = null;
			LoopDownToObject(symbol, type =>
			{
				foreach (var inter in type.AllInterfaces)
					if (inter.Name.Equals("IList", StringComparison.Ordinal) && inter.IsGenericType)
					{

						_elementType = inter.TypeArguments.First();
						return true;
					}
				return false;
			});

			elementType = _elementType;
			return _elementType != null;
		}

		public static bool IsIEnumerable(INamedTypeSymbol symbol)
		{
			bool isIEnumerable = false;
			LoopDownToObject(symbol, type =>
			{
				foreach (var inter in type.AllInterfaces)
					if (inter.Name.Equals("IEnumerable", StringComparison.Ordinal) && !inter.IsGenericType)
					{
						isIEnumerable = true;
						return true;
					}
				return false;
			});
			return isIEnumerable;
		}

		public static string GetNormalizedName(INamedTypeSymbol type)
		{
			var tail = type.IsGenericType ? $"Of{type.TypeArguments.FirstOrDefault().Name}" : "";
			return $"{type.Name}{tail}";
		}

		public static bool IsBindable(INamedTypeSymbol symbol)
		{
			var isBindable = false;

			LoopDownToObject(symbol, type =>
			{
				if (type.ToDisplayString().Equals("Microsoft.Maui.Controls.BindableObject", StringComparison.Ordinal)) isBindable = true;
				return isBindable;
			});

			return isBindable;
		}
	}
}