﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class FlexLayoutGeneratedExtension
    {
        public static T Direction<T>(this T obj,
            Microsoft.Maui.Layouts.FlexDirection direction)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            obj.Direction = direction;
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexDirection>, ValueBuilder<Microsoft.Maui.Layouts.FlexDirection>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexDirection>());
            if (builder.ValueIsSet()) obj.Direction = builder.GetValue();
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Layouts.FlexDirection>, LazyValueBuilder<Microsoft.Maui.Layouts.FlexDirection>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Layouts.FlexDirection>());
            if (builder.ValueIsSet()) obj.Direction = builder.GetValue();
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexDirection>, BindingBuilder<Microsoft.Maui.Layouts.FlexDirection>> buidBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexDirection>(obj, Microsoft.Maui.Controls.FlexLayout.DirectionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T JustifyContent<T>(this T obj,
            Microsoft.Maui.Layouts.FlexJustify justifyContent)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            obj.JustifyContent = justifyContent;
            return obj;
        }
        
        public static T JustifyContent<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexJustify>, ValueBuilder<Microsoft.Maui.Layouts.FlexJustify>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexJustify>());
            if (builder.ValueIsSet()) obj.JustifyContent = builder.GetValue();
            return obj;
        }
        
        public static T JustifyContent<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Layouts.FlexJustify>, LazyValueBuilder<Microsoft.Maui.Layouts.FlexJustify>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Layouts.FlexJustify>());
            if (builder.ValueIsSet()) obj.JustifyContent = builder.GetValue();
            return obj;
        }
        
        public static T JustifyContent<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexJustify>, BindingBuilder<Microsoft.Maui.Layouts.FlexJustify>> buidBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexJustify>(obj, Microsoft.Maui.Controls.FlexLayout.JustifyContentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T AlignContent<T>(this T obj,
            Microsoft.Maui.Layouts.FlexAlignContent alignContent)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            obj.AlignContent = alignContent;
            return obj;
        }
        
        public static T AlignContent<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>, ValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>());
            if (builder.ValueIsSet()) obj.AlignContent = builder.GetValue();
            return obj;
        }
        
        public static T AlignContent<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>, LazyValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>());
            if (builder.ValueIsSet()) obj.AlignContent = builder.GetValue();
            return obj;
        }
        
        public static T AlignContent<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexAlignContent>, BindingBuilder<Microsoft.Maui.Layouts.FlexAlignContent>> buidBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexAlignContent>(obj, Microsoft.Maui.Controls.FlexLayout.AlignContentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T AlignItems<T>(this T obj,
            Microsoft.Maui.Layouts.FlexAlignItems alignItems)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            obj.AlignItems = alignItems;
            return obj;
        }
        
        public static T AlignItems<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>, ValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>());
            if (builder.ValueIsSet()) obj.AlignItems = builder.GetValue();
            return obj;
        }
        
        public static T AlignItems<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>, LazyValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>());
            if (builder.ValueIsSet()) obj.AlignItems = builder.GetValue();
            return obj;
        }
        
        public static T AlignItems<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexAlignItems>, BindingBuilder<Microsoft.Maui.Layouts.FlexAlignItems>> buidBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexAlignItems>(obj, Microsoft.Maui.Controls.FlexLayout.AlignItemsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            Microsoft.Maui.Layouts.FlexPosition position)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            obj.Position = position;
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexPosition>, ValueBuilder<Microsoft.Maui.Layouts.FlexPosition>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexPosition>());
            if (builder.ValueIsSet()) obj.Position = builder.GetValue();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Layouts.FlexPosition>, LazyValueBuilder<Microsoft.Maui.Layouts.FlexPosition>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Layouts.FlexPosition>());
            if (builder.ValueIsSet()) obj.Position = builder.GetValue();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexPosition>, BindingBuilder<Microsoft.Maui.Layouts.FlexPosition>> buidBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexPosition>(obj, Microsoft.Maui.Controls.FlexLayout.PositionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Wrap<T>(this T obj,
            Microsoft.Maui.Layouts.FlexWrap wrap)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            obj.Wrap = wrap;
            return obj;
        }
        
        public static T Wrap<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexWrap>, ValueBuilder<Microsoft.Maui.Layouts.FlexWrap>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexWrap>());
            if (builder.ValueIsSet()) obj.Wrap = builder.GetValue();
            return obj;
        }
        
        public static T Wrap<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Layouts.FlexWrap>, LazyValueBuilder<Microsoft.Maui.Layouts.FlexWrap>> buidValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Layouts.FlexWrap>());
            if (builder.ValueIsSet()) obj.Wrap = builder.GetValue();
            return obj;
        }
        
        public static T Wrap<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexWrap>, BindingBuilder<Microsoft.Maui.Layouts.FlexWrap>> buidBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexWrap>(obj, Microsoft.Maui.Controls.FlexLayout.WrapProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
