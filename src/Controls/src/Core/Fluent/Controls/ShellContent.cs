using Microsoft.Maui.Controls.Fluent;

namespace Microsoft.Maui.Controls
{
	[FluentInterface]
	public partial class ShellContent<T> : ShellContent where T : Page
	{
		public ShellContent() : base()
		{
			this.ContentTemplate = new DataTemplate(typeof(T));
		}

		public ShellContent(string title) : this()
		{
			this.Title = title;
		}
	}
}