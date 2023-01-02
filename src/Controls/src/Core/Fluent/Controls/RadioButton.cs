namespace Microsoft.Maui.Controls
{
	[ContentProperty(nameof(Content))]
	public partial class RadioButton
	{
		public RadioButton(object content) : this()
		{
			this.Content = content;
		}
	}
}