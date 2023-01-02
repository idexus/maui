namespace Microsoft.Maui.Controls
{
	public partial class SwipeGestureRecognizer
	{
		public SwipeGestureRecognizer() { }

		public SwipeGestureRecognizer(SwipeDirection direction) : this()
		{
			this.Direction = direction;
		}
	}
}