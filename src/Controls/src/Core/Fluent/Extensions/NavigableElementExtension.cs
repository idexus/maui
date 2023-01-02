using System.Linq;

namespace Microsoft.Maui.Controls.Fluent
{
	public static class NavigableElementExtension
	{
		public static T StyleClass<T>(this T obj, params string[] styleClasses) where T : NavigableElement
		{
			if (styleClasses.Length > 0)
				obj.StyleClass = (System.Collections.Generic.IList<string>)styleClasses.ToList<string>();
			return obj;
		}
	}
}