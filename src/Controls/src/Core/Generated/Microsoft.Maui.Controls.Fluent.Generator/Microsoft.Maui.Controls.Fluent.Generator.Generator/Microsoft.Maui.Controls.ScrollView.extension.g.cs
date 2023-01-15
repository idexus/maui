﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class ScrollViewGeneratedExtension
    {
        public static T LayoutAreaOverride<T>(this T obj,
            Microsoft.Maui.Graphics.Rect layoutAreaOverride)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.LayoutAreaOverride = layoutAreaOverride;
            return obj;
        }
        
        public static T LayoutAreaOverride<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Rect>, ValueBuilder<Microsoft.Maui.Graphics.Rect>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Rect>());
            if (builder.ValueIsSet()) obj.LayoutAreaOverride = builder.GetValue();
            return obj;
        }
        
        public static T LayoutAreaOverride<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Rect>, LazyValueBuilder<Microsoft.Maui.Graphics.Rect>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Rect>());
            if (builder.ValueIsSet()) obj.LayoutAreaOverride = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.Content = content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.View>, ValueBuilder<Microsoft.Maui.Controls.View>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.View>());
            if (builder.ValueIsSet()) obj.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.View>, LazyValueBuilder<Microsoft.Maui.Controls.View>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.View>());
            if (builder.ValueIsSet()) obj.Content = builder.GetValue();
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            Microsoft.Maui.ScrollOrientation orientation)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.Orientation = orientation;
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollOrientation>, ValueBuilder<Microsoft.Maui.ScrollOrientation>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.ScrollOrientation>());
            if (builder.ValueIsSet()) obj.Orientation = builder.GetValue();
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.ScrollOrientation>, LazyValueBuilder<Microsoft.Maui.ScrollOrientation>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.ScrollOrientation>());
            if (builder.ValueIsSet()) obj.Orientation = builder.GetValue();
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollOrientation>, BindingBuilder<Microsoft.Maui.ScrollOrientation>> buidBinding)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.ScrollOrientation>(obj, Microsoft.Maui.Controls.ScrollView.OrientationProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility horizontalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.HorizontalScrollBarVisibility = horizontalScrollBarVisibility;
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollBarVisibility>, ValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) obj.HorizontalScrollBarVisibility = builder.GetValue();
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.ScrollBarVisibility>, LazyValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) obj.HorizontalScrollBarVisibility = builder.GetValue();
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollBarVisibility>, BindingBuilder<Microsoft.Maui.ScrollBarVisibility>> buidBinding)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.ScrollBarVisibility>(obj, Microsoft.Maui.Controls.ScrollView.HorizontalScrollBarVisibilityProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility verticalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.VerticalScrollBarVisibility = verticalScrollBarVisibility;
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollBarVisibility>, ValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) obj.VerticalScrollBarVisibility = builder.GetValue();
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.ScrollBarVisibility>, LazyValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) obj.VerticalScrollBarVisibility = builder.GetValue();
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollBarVisibility>, BindingBuilder<Microsoft.Maui.ScrollBarVisibility>> buidBinding)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.ScrollBarVisibility>(obj, Microsoft.Maui.Controls.ScrollView.VerticalScrollBarVisibilityProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnScrollToRequested<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ScrollToRequestedEventArgs> handler)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.ScrollToRequested += handler;
            return obj;
        }
        
        public static T OnScrollToRequested<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.ScrollToRequested += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnScrolled<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ScrolledEventArgs> handler)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.Scrolled += handler;
            return obj;
        }
        
        public static T OnScrolled<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            obj.Scrolled += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
