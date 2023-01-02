namespace Microsoft.Maui.Controls
{
	public partial class ListView
	{
		public ListView(System.Collections.IEnumerable itemsSource) : this()
		{
			this.ItemsSource = itemsSource;
		}
	}
}