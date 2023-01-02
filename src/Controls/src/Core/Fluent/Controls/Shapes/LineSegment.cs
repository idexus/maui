using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls.Shapes
{
	public partial class LineSegment
	{
		public LineSegment(double x, double y) : this()
		{
			this.Point = new Point(x, y);
		}
	}
}