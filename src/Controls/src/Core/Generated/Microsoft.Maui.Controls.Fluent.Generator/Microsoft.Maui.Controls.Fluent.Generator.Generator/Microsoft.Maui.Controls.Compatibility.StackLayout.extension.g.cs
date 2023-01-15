﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls.Compatibility
{
	using Microsoft.Maui.Controls.Fluent;

    public static class StackLayoutGeneratedExtension
    {
        public static T Orientation<T>(this T obj,
            Microsoft.Maui.Controls.StackOrientation orientation)
            where T : Microsoft.Maui.Controls.Compatibility.StackLayout
        {
            obj.Orientation = orientation;
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.StackOrientation>, ValueBuilder<Microsoft.Maui.Controls.StackOrientation>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.StackLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.StackOrientation>());
            if (builder.ValueIsSet()) obj.Orientation = builder.GetValue();
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.StackOrientation>, LazyValueBuilder<Microsoft.Maui.Controls.StackOrientation>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.StackLayout
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.StackOrientation>());
            if (builder.ValueIsSet()) obj.Orientation = builder.GetValue();
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.StackOrientation>, BindingBuilder<Microsoft.Maui.Controls.StackOrientation>> buidBinding)
            where T : Microsoft.Maui.Controls.Compatibility.StackLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.StackOrientation>(obj, Microsoft.Maui.Controls.Compatibility.StackLayout.OrientationProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Spacing<T>(this T obj,
            double spacing)
            where T : Microsoft.Maui.Controls.Compatibility.StackLayout
        {
            obj.Spacing = spacing;
            return obj;
        }
        
        public static T Spacing<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.StackLayout
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.Spacing = builder.GetValue();
            return obj;
        }
        
        public static T Spacing<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.StackLayout
        {
            var builder = buidValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) obj.Spacing = builder.GetValue();
            return obj;
        }
        
        public static T Spacing<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Compatibility.StackLayout
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Compatibility.StackLayout.SpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
