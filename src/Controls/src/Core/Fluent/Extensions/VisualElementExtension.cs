﻿namespace Microsoft.Maui.Controls.Fluent
{
	public static class VisualElementExtension
	{
		// Microsoft.Maui.Controls.SemanticProperties - attached properties

		public static T SemanticHint<T>(this T obj, string hintProperty) where T : VisualElement
		{
			obj.SetValue(SemanticProperties.HintProperty, hintProperty);
			return obj;
		}

		public static T SemanticDescription<T>(this T obj, string description) where T : VisualElement
		{
			obj.SetValue(SemanticProperties.DescriptionProperty, description);
			return obj;
		}

		public static T SemanticHeadingLevel<T>(this T obj, SemanticHeadingLevel headingLevel) where T : VisualElement
		{
			obj.SetValue(SemanticProperties.HeadingLevelProperty, headingLevel);
			return obj;
		}

		// Microsoft.Maui.Controls.AutomationProperties - attached properties

		public static T AutomationExcludedWithChildren<T>(this T obj, bool? excludedWithChildren) where T : VisualElement
		{
			obj.SetValue(AutomationProperties.ExcludedWithChildrenProperty, excludedWithChildren);
			return obj;
		}

		public static T AutomationIsInAccessibleTree<T>(this T obj, bool? isInAccessibleTree) where T : VisualElement
		{
			obj.SetValue(AutomationProperties.IsInAccessibleTreeProperty, isInAccessibleTree);
			return obj;
		}

		public static T AutomationName<T>(this T obj, string name) where T : VisualElement
		{
			obj.SetValue(AutomationProperties.NameProperty, name);
			return obj;
		}

		public static T AutomationHelpText<T>(this T obj, string helpText) where T : VisualElement
		{
			obj.SetValue(AutomationProperties.HelpTextProperty, helpText);
			return obj;
		}

		public static T AutomationLabeledBy<T>(this T obj, VisualElement labeledBy) where T : VisualElement
		{
			obj.SetValue(AutomationProperties.LabeledByProperty, labeledBy);
			return obj;
		}

		// ------------

		public static T SizeRequest<T>(this T obj, double widthRequest, double heightRequest)
			where T : VisualElement
		{
			obj.WidthRequest = widthRequest;
			obj.HeightRequest = heightRequest;
			return obj;
		}
	}
}
