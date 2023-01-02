namespace Microsoft.Maui.Controls.Fluent
{
	public static class BaseShellItemExtension
	{		
		public static T ShellItemTemplate<T>(this T obj, DataTemplate dataTemplate) where T : Element
		{
			obj.SetValue(Shell.ItemTemplateProperty, dataTemplate);
			return obj;
		}
	}
}
