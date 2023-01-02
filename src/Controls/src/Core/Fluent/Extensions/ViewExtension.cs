namespace Microsoft.Maui.Controls.Fluent
{
	public static class ViewExtension
	{
		public static T Column<T>(this T obj, int column) where T : BindableObject, IView
		{
			obj.SetValue(Grid.ColumnProperty, column);
			return obj;
		}

		public static T Row<T>(this T obj, int row) where T : BindableObject, IView
		{
			obj.SetValue(Grid.RowProperty, row);
			return obj;
		}

		public static T ColumnSpan<T>(this T obj, int columnSpan) where T : BindableObject, IView
		{
			obj.SetValue(Grid.ColumnSpanProperty, columnSpan);
			return obj;
		}

		public static T RowSpan<T>(this T obj, int rowSpan) where T : BindableObject, IView
		{
			obj.SetValue(Grid.RowSpanProperty, rowSpan);
			return obj;
		}

		public static T GridSpan<T>(this T obj, int column = 1, int row = 1) where T : BindableObject, IView
		{
			obj.SetValue(Grid.ColumnSpanProperty, column);
			obj.SetValue(Grid.RowSpanProperty, row);
			return obj;
		}
	}
}