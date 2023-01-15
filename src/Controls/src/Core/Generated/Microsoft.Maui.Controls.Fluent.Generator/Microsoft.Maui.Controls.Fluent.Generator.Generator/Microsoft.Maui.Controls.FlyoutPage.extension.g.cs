﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class FlyoutPageGeneratedExtension
    {
        public static T Detail<T>(this T obj,
            Microsoft.Maui.Controls.Page detail)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.Detail = detail;
            return obj;
        }
        
        public static T Detail<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Page>, ValueBuilder<Microsoft.Maui.Controls.Page>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Page>());
            if (builder.ValueIsSet()) obj.Detail = builder.GetValue();
            return obj;
        }
        
        public static T Detail<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.Page>, LazyValueBuilder<Microsoft.Maui.Controls.Page>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.Page>());
            if (builder.ValueIsSet()) obj.Detail = builder.GetValue();
            return obj;
        }
        
        public static T IsGestureEnabled<T>(this T obj,
            bool isGestureEnabled)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.IsGestureEnabled = isGestureEnabled;
            return obj;
        }
        
        public static T IsGestureEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsGestureEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsGestureEnabled<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsGestureEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsGestureEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.FlyoutPage.IsGestureEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsPresented<T>(this T obj,
            bool isPresented)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.IsPresented = isPresented;
            return obj;
        }
        
        public static T IsPresented<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsPresented = builder.GetValue();
            return obj;
        }
        
        public static T IsPresented<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsPresented = builder.GetValue();
            return obj;
        }
        
        public static T IsPresented<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.FlyoutPage.IsPresentedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Flyout<T>(this T obj,
            Microsoft.Maui.Controls.Page flyout)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.Flyout = flyout;
            return obj;
        }
        
        public static T Flyout<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Page>, ValueBuilder<Microsoft.Maui.Controls.Page>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Page>());
            if (builder.ValueIsSet()) obj.Flyout = builder.GetValue();
            return obj;
        }
        
        public static T Flyout<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.Page>, LazyValueBuilder<Microsoft.Maui.Controls.Page>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.Page>());
            if (builder.ValueIsSet()) obj.Flyout = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutLayoutBehavior<T>(this T obj,
            Microsoft.Maui.Controls.FlyoutLayoutBehavior flyoutLayoutBehavior)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.FlyoutLayoutBehavior = flyoutLayoutBehavior;
            return obj;
        }
        
        public static T FlyoutLayoutBehavior<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>, ValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>());
            if (builder.ValueIsSet()) obj.FlyoutLayoutBehavior = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutLayoutBehavior<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>, LazyValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>> buidValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>());
            if (builder.ValueIsSet()) obj.FlyoutLayoutBehavior = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutLayoutBehavior<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>, BindingBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>> buidBinding)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>(obj, Microsoft.Maui.Controls.FlyoutPage.FlyoutLayoutBehaviorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnIsPresentedChanged<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.IsPresentedChanged += handler;
            return obj;
        }
        
        public static T OnIsPresentedChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.IsPresentedChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnBackButtonPressed<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.BackButtonPressedEventArgs> handler)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.BackButtonPressed += handler;
            return obj;
        }
        
        public static T OnBackButtonPressed<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            obj.BackButtonPressed += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
