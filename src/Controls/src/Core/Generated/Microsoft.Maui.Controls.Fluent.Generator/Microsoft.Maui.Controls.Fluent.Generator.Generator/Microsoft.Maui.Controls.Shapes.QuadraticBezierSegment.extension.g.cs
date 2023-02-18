﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls.Shapes
{
	using Microsoft.Maui.Controls.Fluent;

    public static class QuadraticBezierSegmentGeneratedExtension
    {
        public static T Point1<T>(this T obj,
            Microsoft.Maui.Graphics.Point point1)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            obj.Point1 = point1;
            return obj;
        }
        
        public static T Point1<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) obj.Point1 = builder.GetValue();
            return obj;
        }
        
        public static T Point1<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Point>, LazyValueBuilder<Microsoft.Maui.Graphics.Point>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) obj.Point1 = builder.GetValue();
            return obj;
        }
        
        public static T Point1<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(obj, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property));
            builder.BindProperty();
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            Microsoft.Maui.Graphics.Point point2)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            obj.Point2 = point2;
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) obj.Point2 = builder.GetValue();
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Point>, LazyValueBuilder<Microsoft.Maui.Graphics.Point>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) obj.Point2 = builder.GetValue();
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(obj, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore