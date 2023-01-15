﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls.Shapes
{
	using Microsoft.Maui.Controls.Fluent;

    public static class TranslateTransformGeneratedExtension
    {
        public static T X<T>(this T obj,
            double x)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            obj.X = x;
            return obj;
        }
        
        public static T X<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.X = builder.GetValue();
            return obj;
        }
        
        public static T X<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buidValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) obj.X = builder.GetValue();
            return obj;
        }
        
        public static T X<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.TranslateTransform.XProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Y<T>(this T obj,
            double y)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            obj.Y = y;
            return obj;
        }
        
        public static T Y<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.Y = builder.GetValue();
            return obj;
        }
        
        public static T Y<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buidValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) obj.Y = builder.GetValue();
            return obj;
        }
        
        public static T Y<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.TranslateTransform.YProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
