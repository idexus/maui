﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class SwipeItemViewGeneratedExtension
    {
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            obj.Command = command;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<LazyValueBuilder<System.Windows.Input.ICommand>, LazyValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            var builder = buidValue(new LazyValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.SwipeItemView.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            obj.CommandParameter = commandParameter;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            var builder = buidValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) obj.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.SwipeItemView.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnInvoked<T>(this T obj, System.EventHandler<System.EventArgs> handler)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            obj.Invoked += handler;
            return obj;
        }
        
        public static T OnInvoked<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.SwipeItemView
        {
            obj.Invoked += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
