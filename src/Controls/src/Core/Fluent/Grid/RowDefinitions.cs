using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Maui.Controls.Fluent
{
	public class RowDefinitionBuilder : IEnumerable<RowDefinition>
	{
		List<RowDefinition> items = new List<RowDefinition>();

		public IEnumerator<RowDefinition> GetEnumerator() => items.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();

		public RowDefinitionBuilder Auto()
		{
			items.Add(new RowDefinition(0, GridUnitType.Auto));
			return this;
		}

		public RowDefinitionBuilder Star(double height = 1)
		{
			items.Add(new RowDefinition(height, GridUnitType.Star));
			return this;
		}

		public RowDefinitionBuilder Absolute(double height)
		{
			items.Add(new RowDefinition(height, GridUnitType.Absolute));
			return this;
		}
	}
}

