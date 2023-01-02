namespace Microsoft.Maui.Controls
{
	public partial class ColumnDefinition
	{
		public ColumnDefinition(double width, GridUnitType unitType) : this()
		{
			this.Width = new GridLength(width, unitType);
		}
	}
}