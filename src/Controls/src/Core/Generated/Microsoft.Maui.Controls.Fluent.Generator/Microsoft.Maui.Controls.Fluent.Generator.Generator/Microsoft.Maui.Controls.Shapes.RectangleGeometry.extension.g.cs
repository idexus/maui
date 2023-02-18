﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls.Shapes
{
	using Microsoft.Maui.Controls.Fluent;

    public static class RectangleGeometryGeneratedExtension
    {
        public static T Rect<T>(this T obj,
            Microsoft.Maui.Graphics.Rect rect)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            obj.Rect = rect;
            return obj;
        }
        
        public static T Rect<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Rect>, ValueBuilder<Microsoft.Maui.Graphics.Rect>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Rect>());
            if (builder.ValueIsSet()) obj.Rect = builder.GetValue();
            return obj;
        }
        
        public static T Rect<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Rect>, LazyValueBuilder<Microsoft.Maui.Graphics.Rect>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Rect>());
            if (builder.ValueIsSet()) obj.Rect = builder.GetValue();
            return obj;
        }
        
        public static T Rect<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Rect>, BindingBuilder<Microsoft.Maui.Graphics.Rect>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Rect>(obj, Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore