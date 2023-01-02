namespace Microsoft.Maui.Controls
{
	public partial class FontImageSource
	{
		public FontImageSource() { }

		public FontImageSource(string glyph, string fontFamily) : this()
		{
			this.Glyph = glyph;
			this.FontFamily = fontFamily;
		}
	}
}