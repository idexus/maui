﻿using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls.Fluent
{
	public static class ContentPageExtension
	{
		public static T ShellPresentationMode<T>(this T obj, PresentationMode presentationMode) where T : Element
		{
			obj.SetValue(Shell.PresentationModeProperty, presentationMode);
			return obj;
		}

		public static T ShellBackgroundColor<T>(this T obj, Color color) where T : Element
		{
			obj.SetValue(Shell.BackgroundColorProperty, color);
			return obj;
		}

		public static T ShellForegroundColor<T>(this T obj, Color color) where T : Element
		{
			obj.SetValue(Shell.ForegroundColorProperty, color);
			return obj;
		}

		public static T ShellTitleColor<T>(this T obj, Color color) where T : Element
		{
			obj.SetValue(Shell.TitleColorProperty, color);
			return obj;
		}

		public static T ShellDisabledColor<T>(this T obj, Color color) where T : Element
		{
			obj.SetValue(Shell.DisabledColorProperty, color);
			return obj;
		}

		public static T ShellUnselectedColor<T>(this T obj, Color color) where T : Element
		{
			obj.SetValue(Shell.UnselectedColorProperty, color);
			return obj;
		}

		public static T ShellNavBarHasShadow<T>(this T obj, bool hasShadow) where T : Element
		{
			obj.SetValue(Shell.NavBarHasShadowProperty, hasShadow);
			return obj;
		}

		public static T ShellNavBarIsVisible<T>(this T obj, bool isVisible) where T : Element
		{
			obj.SetValue(Shell.NavBarIsVisibleProperty, isVisible);
			return obj;
		}

		public static T ShellTitleView<T>(this T obj, View view) where T : Element
		{
			obj.SetValue(Shell.TitleViewProperty, view);
			return obj;
		}
	}
}
