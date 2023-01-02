using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls.Shapes
{
	public partial class RectangleGeometry
	{
		public RectangleGeometry(double x, double y, double width, double height) : this()
		{
			this.Rect = new Rect(x, y, width, height);
		}
	}
}