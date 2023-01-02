using Microsoft.Maui.Controls.Fluent;

namespace Microsoft.Maui.Controls
{
	[FluentInterface]
	public partial class VisualStateGroup
	{
		public VisualStateGroup(string name) : this()
		{
			this.Name = name;
		}

		public const string CommonStates = "CommonStates";
	}
}

