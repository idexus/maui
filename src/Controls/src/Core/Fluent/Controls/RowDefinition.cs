namespace Microsoft.Maui.Controls
{
	public partial class RowDefinition
	{
		public RowDefinition(double height, GridUnitType unitType) : this()
		{
			this.Height = new GridLength(height, unitType);
		}
	}
}