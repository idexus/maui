﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class ShellItemGeneratedExtension
    {
        public static T CurrentItem<T>(this T obj,
            Microsoft.Maui.Controls.ShellSection currentItem)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            obj.CurrentItem = currentItem;
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ShellSection>, ValueBuilder<Microsoft.Maui.Controls.ShellSection>> buidValue)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ShellSection>());
            if (builder.ValueIsSet()) obj.CurrentItem = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.ShellSection>, LazyValueBuilder<Microsoft.Maui.Controls.ShellSection>> buidValue)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.ShellSection>());
            if (builder.ValueIsSet()) obj.CurrentItem = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ShellSection>, BindingBuilder<Microsoft.Maui.Controls.ShellSection>> buidBinding)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ShellSection>(obj, Microsoft.Maui.Controls.ShellItem.CurrentItemProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Items<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellSection> items)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            foreach (var item in items)
                obj.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            params Microsoft.Maui.Controls.ShellSection[] items)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            foreach (var item in items)
                obj.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellSection>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellSection>>> buidValue)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            var builder = buidValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellSection>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                    obj.Items.Add(item);
            }
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
