﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class ShellGeneratedExtension
    {
        public static T FlyoutVerticalScrollMode<T>(this T obj,
            Microsoft.Maui.Controls.ScrollMode flyoutVerticalScrollMode)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutVerticalScrollMode = flyoutVerticalScrollMode;
            return obj;
        }
        
        public static T FlyoutVerticalScrollMode<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ScrollMode>, ValueBuilder<Microsoft.Maui.Controls.ScrollMode>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ScrollMode>());
            if (builder.ValueIsSet()) obj.FlyoutVerticalScrollMode = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutVerticalScrollMode<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.ScrollMode>, LazyValueBuilder<Microsoft.Maui.Controls.ScrollMode>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.ScrollMode>());
            if (builder.ValueIsSet()) obj.FlyoutVerticalScrollMode = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutVerticalScrollMode<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ScrollMode>, BindingBuilder<Microsoft.Maui.Controls.ScrollMode>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ScrollMode>(obj, Microsoft.Maui.Controls.Shell.FlyoutVerticalScrollModeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource flyoutIcon)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutIcon = flyoutIcon;
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.FlyoutIcon = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>, LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.FlyoutIcon = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.Shell.FlyoutIconProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            Microsoft.Maui.Controls.ShellItem currentItem)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.CurrentItem = currentItem;
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ShellItem>, ValueBuilder<Microsoft.Maui.Controls.ShellItem>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ShellItem>());
            if (builder.ValueIsSet()) obj.CurrentItem = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.ShellItem>, LazyValueBuilder<Microsoft.Maui.Controls.ShellItem>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.ShellItem>());
            if (builder.ValueIsSet()) obj.CurrentItem = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ShellItem>, BindingBuilder<Microsoft.Maui.Controls.ShellItem>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ShellItem>(obj, Microsoft.Maui.Controls.Shell.CurrentItemProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutBackgroundImage<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource flyoutBackgroundImage)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutBackgroundImage = flyoutBackgroundImage;
            return obj;
        }
        
        public static T FlyoutBackgroundImage<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.FlyoutBackgroundImage = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackgroundImage<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>, LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.FlyoutBackgroundImage = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackgroundImage<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.Shell.FlyoutBackgroundImageProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutBackgroundImageAspect<T>(this T obj,
            Microsoft.Maui.Aspect flyoutBackgroundImageAspect)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutBackgroundImageAspect = flyoutBackgroundImageAspect;
            return obj;
        }
        
        public static T FlyoutBackgroundImageAspect<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Aspect>, ValueBuilder<Microsoft.Maui.Aspect>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Aspect>());
            if (builder.ValueIsSet()) obj.FlyoutBackgroundImageAspect = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackgroundImageAspect<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Aspect>, LazyValueBuilder<Microsoft.Maui.Aspect>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Aspect>());
            if (builder.ValueIsSet()) obj.FlyoutBackgroundImageAspect = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackgroundImageAspect<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Aspect>, BindingBuilder<Microsoft.Maui.Aspect>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Aspect>(obj, Microsoft.Maui.Controls.Shell.FlyoutBackgroundImageAspectProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color flyoutBackgroundColor)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutBackgroundColor = flyoutBackgroundColor;
            return obj;
        }
        
        public static T FlyoutBackgroundColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.FlyoutBackgroundColor = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackgroundColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.FlyoutBackgroundColor = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackgroundColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.Shell.FlyoutBackgroundColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutBackground<T>(this T obj,
            Microsoft.Maui.Controls.Brush flyoutBackground)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutBackground = flyoutBackground;
            return obj;
        }
        
        public static T FlyoutBackground<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Brush>, ValueBuilder<Microsoft.Maui.Controls.Brush>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) obj.FlyoutBackground = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackground<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.Brush>, LazyValueBuilder<Microsoft.Maui.Controls.Brush>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) obj.FlyoutBackground = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackground<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Brush>, BindingBuilder<Microsoft.Maui.Controls.Brush>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Brush>(obj, Microsoft.Maui.Controls.Shell.FlyoutBackgroundProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutBackdrop<T>(this T obj,
            Microsoft.Maui.Controls.Brush flyoutBackdrop)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutBackdrop = flyoutBackdrop;
            return obj;
        }
        
        public static T FlyoutBackdrop<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Brush>, ValueBuilder<Microsoft.Maui.Controls.Brush>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) obj.FlyoutBackdrop = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackdrop<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.Brush>, LazyValueBuilder<Microsoft.Maui.Controls.Brush>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) obj.FlyoutBackdrop = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBackdrop<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Brush>, BindingBuilder<Microsoft.Maui.Controls.Brush>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Brush>(obj, Microsoft.Maui.Controls.Shell.FlyoutBackdropProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutWidth<T>(this T obj,
            double flyoutWidth)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutWidth = flyoutWidth;
            return obj;
        }
        
        public static T FlyoutWidth<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.FlyoutWidth = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutWidth<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) obj.FlyoutWidth = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutWidth<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shell.FlyoutWidthProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutHeight<T>(this T obj,
            double flyoutHeight)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutHeight = flyoutHeight;
            return obj;
        }
        
        public static T FlyoutHeight<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.FlyoutHeight = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutHeight<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) obj.FlyoutHeight = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutHeight<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shell.FlyoutHeightProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutBehavior<T>(this T obj,
            Microsoft.Maui.FlyoutBehavior flyoutBehavior)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutBehavior = flyoutBehavior;
            return obj;
        }
        
        public static T FlyoutBehavior<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.FlyoutBehavior>, ValueBuilder<Microsoft.Maui.FlyoutBehavior>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.FlyoutBehavior>());
            if (builder.ValueIsSet()) obj.FlyoutBehavior = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBehavior<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.FlyoutBehavior>, LazyValueBuilder<Microsoft.Maui.FlyoutBehavior>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.FlyoutBehavior>());
            if (builder.ValueIsSet()) obj.FlyoutBehavior = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutBehavior<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.FlyoutBehavior>, BindingBuilder<Microsoft.Maui.FlyoutBehavior>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.FlyoutBehavior>(obj, Microsoft.Maui.Controls.Shell.FlyoutBehaviorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutHeader<T>(this T obj,
            object flyoutHeader)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutHeader = flyoutHeader;
            return obj;
        }
        
        public static T FlyoutHeader<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.FlyoutHeader = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutHeader<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) obj.FlyoutHeader = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutHeader<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Shell.FlyoutHeaderProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutFooter<T>(this T obj,
            object flyoutFooter)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutFooter = flyoutFooter;
            return obj;
        }
        
        public static T FlyoutFooter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.FlyoutFooter = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutFooter<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) obj.FlyoutFooter = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutFooter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Shell.FlyoutFooterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutHeaderBehavior<T>(this T obj,
            Microsoft.Maui.Controls.FlyoutHeaderBehavior flyoutHeaderBehavior)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutHeaderBehavior = flyoutHeaderBehavior;
            return obj;
        }
        
        public static T FlyoutHeaderBehavior<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>, ValueBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>());
            if (builder.ValueIsSet()) obj.FlyoutHeaderBehavior = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutHeaderBehavior<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>, LazyValueBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>());
            if (builder.ValueIsSet()) obj.FlyoutHeaderBehavior = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutHeaderBehavior<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>, BindingBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.FlyoutHeaderBehavior>(obj, Microsoft.Maui.Controls.Shell.FlyoutHeaderBehaviorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutHeaderTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate flyoutHeaderTemplate)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutHeaderTemplate = flyoutHeaderTemplate;
            return obj;
        }
        
        public static T FlyoutHeaderTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.FlyoutHeaderTemplate = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutHeaderTemplate<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>, LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.FlyoutHeaderTemplate = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutHeaderTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.Shell.FlyoutHeaderTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutFooterTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate flyoutFooterTemplate)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutFooterTemplate = flyoutFooterTemplate;
            return obj;
        }
        
        public static T FlyoutFooterTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.FlyoutFooterTemplate = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutFooterTemplate<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>, LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.FlyoutFooterTemplate = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutFooterTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.Shell.FlyoutFooterTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutIsPresented<T>(this T obj,
            bool flyoutIsPresented)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutIsPresented = flyoutIsPresented;
            return obj;
        }
        
        public static T FlyoutIsPresented<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.FlyoutIsPresented = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutIsPresented<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.FlyoutIsPresented = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutIsPresented<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Shell.FlyoutIsPresentedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Items<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellItem> items)
            where T : Microsoft.Maui.Controls.Shell
        {
            foreach (var item in items)
                obj.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            params Microsoft.Maui.Controls.ShellItem[] items)
            where T : Microsoft.Maui.Controls.Shell
        {
            foreach (var item in items)
                obj.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellItem>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellItem>>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellItem>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                    obj.Items.Add(item);
            }
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate itemTemplate)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.ItemTemplate = itemTemplate;
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.ItemTemplate = builder.GetValue();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>, LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.ItemTemplate = builder.GetValue();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.Shell.ItemTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T MenuItemTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate menuItemTemplate)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.MenuItemTemplate = menuItemTemplate;
            return obj;
        }
        
        public static T MenuItemTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.MenuItemTemplate = builder.GetValue();
            return obj;
        }
        
        public static T MenuItemTemplate<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>, LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.MenuItemTemplate = builder.GetValue();
            return obj;
        }
        
        public static T MenuItemTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.Shell.MenuItemTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutContent<T>(this T obj,
            object flyoutContent)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutContent = flyoutContent;
            return obj;
        }
        
        public static T FlyoutContent<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.FlyoutContent = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutContent<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) obj.FlyoutContent = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutContent<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Shell.FlyoutContentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutContentTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate flyoutContentTemplate)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.FlyoutContentTemplate = flyoutContentTemplate;
            return obj;
        }
        
        public static T FlyoutContentTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.FlyoutContentTemplate = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutContentTemplate<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>, LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.FlyoutContentTemplate = builder.GetValue();
            return obj;
        }
        
        public static T FlyoutContentTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.Shell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.Shell.FlyoutContentTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnNavigated<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ShellNavigatedEventArgs> handler)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.Navigated += handler;
            return obj;
        }
        
        public static T OnNavigated<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.Navigated += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnNavigating<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ShellNavigatingEventArgs> handler)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.Navigating += handler;
            return obj;
        }
        
        public static T OnNavigating<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Shell
        {
            obj.Navigating += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
