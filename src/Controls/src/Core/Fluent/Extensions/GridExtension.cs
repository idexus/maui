using Microsoft.Maui.Controls;

namespace Microsoft.Maui.Controls.Fluent
{
	public static class GridExtension
	{
		public static Grid RowDefinitions(this Grid obj, RowDefinitionBuilder definitionBuilder)
		{
			foreach (var rowDef in definitionBuilder)
				obj.RowDefinitions.Add(rowDef);
			return obj;
		}

		public static Grid RowDefinitions(this Grid obj, System.Func<RowDefinitionBuilder, RowDefinitionBuilder> build)
		{
			var rowDefs = build(new RowDefinitionBuilder());
			foreach (var rowDef in rowDefs)
				obj.RowDefinitions.Add(rowDef);
			return obj;
		}

		public static Grid ColumnDefinitions(this Grid obj, ColumnDefinitionBuilder definitionBuilder)
		{
			foreach (var colDef in definitionBuilder)
				obj.ColumnDefinitions.Add(colDef);
			return obj;
		}

		public static Grid ColumnDefinitions(this Grid obj, System.Func<ColumnDefinitionBuilder, ColumnDefinitionBuilder> build)
		{
			var colDefs = build(new ColumnDefinitionBuilder());
			foreach (var colDef in colDefs)
				obj.ColumnDefinitions.Add(colDef);
			return obj;
		}
	}
}
