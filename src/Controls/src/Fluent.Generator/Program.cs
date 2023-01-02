using Microsoft.CodeAnalysis;

namespace Microsoft.Maui.Controls.Fluent.Generator
{
	[Generator]
	public class Generator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context) { }

		public void Execute(GeneratorExecutionContext context)
		{
			//Helpers.WaitForDebugger(context.CancellationToken);
			new FluentGenerator(context).Generate();
		}
	}
}

