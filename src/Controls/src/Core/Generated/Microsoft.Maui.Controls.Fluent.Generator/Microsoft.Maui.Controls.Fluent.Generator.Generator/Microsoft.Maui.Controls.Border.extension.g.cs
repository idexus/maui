﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class BorderGeneratedExtension
    {
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View? content)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.Content = content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.View?>, ValueBuilder<Microsoft.Maui.Controls.View?>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.View?>());
            if (builder.ValueIsSet()) obj.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.View?>, LazyValueBuilder<Microsoft.Maui.Controls.View?>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.View?>());
            if (builder.ValueIsSet()) obj.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.View?>, BindingBuilder<Microsoft.Maui.Controls.View?>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.View?>(obj, Microsoft.Maui.Controls.Border.ContentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.Padding = padding;
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) obj.Padding = builder.GetValue();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Thickness>, LazyValueBuilder<Microsoft.Maui.Thickness>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) obj.Padding = builder.GetValue();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Thickness>(obj, Microsoft.Maui.Controls.Border.PaddingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StrokeShape<T>(this T obj,
            Microsoft.Maui.Graphics.IShape? strokeShape)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.StrokeShape = strokeShape;
            return obj;
        }
        
        public static T StrokeShape<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.IShape?>, ValueBuilder<Microsoft.Maui.Graphics.IShape?>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.IShape?>());
            if (builder.ValueIsSet()) obj.StrokeShape = builder.GetValue();
            return obj;
        }
        
        public static T StrokeShape<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.IShape?>, LazyValueBuilder<Microsoft.Maui.Graphics.IShape?>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Graphics.IShape?>());
            if (builder.ValueIsSet()) obj.StrokeShape = builder.GetValue();
            return obj;
        }
        
        public static T StrokeShape<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.IShape?>, BindingBuilder<Microsoft.Maui.Graphics.IShape?>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.IShape?>(obj, Microsoft.Maui.Controls.Border.StrokeShapeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Stroke<T>(this T obj,
            Microsoft.Maui.Controls.Brush? stroke)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.Stroke = stroke;
            return obj;
        }
        
        public static T Stroke<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Brush?>, ValueBuilder<Microsoft.Maui.Controls.Brush?>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Brush?>());
            if (builder.ValueIsSet()) obj.Stroke = builder.GetValue();
            return obj;
        }
        
        public static T Stroke<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.Brush?>, LazyValueBuilder<Microsoft.Maui.Controls.Brush?>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.Brush?>());
            if (builder.ValueIsSet()) obj.Stroke = builder.GetValue();
            return obj;
        }
        
        public static T Stroke<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Brush?>, BindingBuilder<Microsoft.Maui.Controls.Brush?>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Brush?>(obj, Microsoft.Maui.Controls.Border.StrokeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StrokeThickness<T>(this T obj,
            double strokeThickness)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.StrokeThickness = strokeThickness;
            return obj;
        }
        
        public static T StrokeThickness<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.StrokeThickness = builder.GetValue();
            return obj;
        }
        
        public static T StrokeThickness<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) obj.StrokeThickness = builder.GetValue();
            return obj;
        }
        
        public static T StrokeThickness<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Border.StrokeThicknessProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StrokeDashArray<T>(this T obj,
            Microsoft.Maui.Controls.DoubleCollection? strokeDashArray)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.StrokeDashArray = strokeDashArray;
            return obj;
        }
        
        public static T StrokeDashArray<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DoubleCollection?>, ValueBuilder<Microsoft.Maui.Controls.DoubleCollection?>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DoubleCollection?>());
            if (builder.ValueIsSet()) obj.StrokeDashArray = builder.GetValue();
            return obj;
        }
        
        public static T StrokeDashArray<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.DoubleCollection?>, LazyValueBuilder<Microsoft.Maui.Controls.DoubleCollection?>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.DoubleCollection?>());
            if (builder.ValueIsSet()) obj.StrokeDashArray = builder.GetValue();
            return obj;
        }
        
        public static T StrokeDashArray<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DoubleCollection?>, BindingBuilder<Microsoft.Maui.Controls.DoubleCollection?>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DoubleCollection?>(obj, Microsoft.Maui.Controls.Border.StrokeDashArrayProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StrokeDashOffset<T>(this T obj,
            double strokeDashOffset)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.StrokeDashOffset = strokeDashOffset;
            return obj;
        }
        
        public static T StrokeDashOffset<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.StrokeDashOffset = builder.GetValue();
            return obj;
        }
        
        public static T StrokeDashOffset<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) obj.StrokeDashOffset = builder.GetValue();
            return obj;
        }
        
        public static T StrokeDashOffset<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StrokeLineCap<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.StrokeLineCap = strokeLineCap;
            return obj;
        }
        
        public static T StrokeLineCap<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>, ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>());
            if (builder.ValueIsSet()) obj.StrokeLineCap = builder.GetValue();
            return obj;
        }
        
        public static T StrokeLineCap<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>, LazyValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>());
            if (builder.ValueIsSet()) obj.StrokeLineCap = builder.GetValue();
            return obj;
        }
        
        public static T StrokeLineCap<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>, BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>(obj, Microsoft.Maui.Controls.Border.StrokeLineCapProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StrokeLineJoin<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.StrokeLineJoin = strokeLineJoin;
            return obj;
        }
        
        public static T StrokeLineJoin<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>, ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>());
            if (builder.ValueIsSet()) obj.StrokeLineJoin = builder.GetValue();
            return obj;
        }
        
        public static T StrokeLineJoin<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>, LazyValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>());
            if (builder.ValueIsSet()) obj.StrokeLineJoin = builder.GetValue();
            return obj;
        }
        
        public static T StrokeLineJoin<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>, BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>(obj, Microsoft.Maui.Controls.Border.StrokeLineJoinProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StrokeMiterLimit<T>(this T obj,
            double strokeMiterLimit)
            where T : Microsoft.Maui.Controls.Border
        {
            obj.StrokeMiterLimit = strokeMiterLimit;
            return obj;
        }
        
        public static T StrokeMiterLimit<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.StrokeMiterLimit = builder.GetValue();
            return obj;
        }
        
        public static T StrokeMiterLimit<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) obj.StrokeMiterLimit = builder.GetValue();
            return obj;
        }
        
        public static T StrokeMiterLimit<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Border
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
