namespace Microsoft.Maui.Controls
{
	public partial class GraphicsView
	{
		public GraphicsView() { }

		public GraphicsView(Graphics.IDrawable drawable) : this()
		{
			this.Drawable = drawable;
		}
	}
}