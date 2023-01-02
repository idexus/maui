namespace Microsoft.Maui.Controls.Fluent
{
	public static class PublicExtension
	{
		public static T Assign<T>(this T _obj, out T obj) { obj = _obj; return obj; }
		public static T Configure<T>(this T obj, System.Action<T> action) { action(obj); return obj; }
	}
}
