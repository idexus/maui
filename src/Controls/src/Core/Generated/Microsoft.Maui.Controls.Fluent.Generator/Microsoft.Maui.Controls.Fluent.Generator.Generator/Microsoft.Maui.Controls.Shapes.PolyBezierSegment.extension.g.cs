﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls.Shapes
{
	using Microsoft.Maui.Controls.Fluent;

    public static class PolyBezierSegmentGeneratedExtension
    {
        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment obj,
            Microsoft.Maui.Controls.PointCollection points)
        {
            obj.Points = points;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.PointCollection>, ValueBuilder<Microsoft.Maui.Controls.PointCollection>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.PointCollection>());
            if (builder.ValueIsSet()) obj.Points = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.PointCollection>, LazyValueBuilder<Microsoft.Maui.Controls.PointCollection>> buidValue)
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.PointCollection>());
            if (builder.ValueIsSet()) obj.Points = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.PointCollection>, BindingBuilder<Microsoft.Maui.Controls.PointCollection>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.PointCollection>(obj, Microsoft.Maui.Controls.Shapes.PolyBezierSegment.PointsProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore