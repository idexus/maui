﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class BindableObjectGeneratedExtension
    {
        public static T BindingContext<T>(this T obj,
            object bindingContext)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            obj.BindingContext = bindingContext;
            return obj;
        }
        
        public static T BindingContext<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.BindingContext = builder.GetValue();
            return obj;
        }
        
        public static T BindingContext<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            var builder = buidValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) obj.BindingContext = builder.GetValue();
            return obj;
        }
        
        public static T BindingContext<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BindableObject.BindingContextProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnPropertyChanged<T>(this T obj, System.ComponentModel.PropertyChangedEventHandler handler)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            obj.PropertyChanged += handler;
            return obj;
        }
        
        public static T OnPropertyChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            obj.PropertyChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnPropertyChanging<T>(this T obj, Microsoft.Maui.Controls.PropertyChangingEventHandler handler)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            obj.PropertyChanging += handler;
            return obj;
        }
        
        public static T OnPropertyChanging<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            obj.PropertyChanging += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnBindingContextChanged<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            obj.BindingContextChanged += handler;
            return obj;
        }
        
        public static T OnBindingContextChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.BindableObject
        {
            obj.BindingContextChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore