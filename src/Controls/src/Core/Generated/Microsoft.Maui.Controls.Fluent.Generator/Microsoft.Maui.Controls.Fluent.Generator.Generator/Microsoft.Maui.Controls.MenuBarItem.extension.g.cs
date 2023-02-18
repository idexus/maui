﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class MenuBarItemGeneratedExtension
    {
        public static T Priority<T>(this T obj,
            int priority)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            obj.Priority = priority;
            return obj;
        }
        
        public static T Priority<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.Priority = builder.GetValue();
            return obj;
        }
        
        public static T Priority<T>(this T obj,
            System.Func<LazyValueBuilder<int>, LazyValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            var builder = buidValue(new LazyValueBuilder<int>());
            if (builder.ValueIsSet()) obj.Priority = builder.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool isEnabled)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            obj.IsEnabled = isEnabled;
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            var builder = buidValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.MenuBarItem.IsEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string text)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            obj.Text = text;
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Text = builder.GetValue();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            var builder = buidValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Text = builder.GetValue();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.MenuBarItem
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.MenuBarItem.TextProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore