﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class ShellSectionGeneratedExtension
    {
        public static T CurrentItem<T>(this T obj,
            Microsoft.Maui.Controls.ShellContent currentItem)
            where T : Microsoft.Maui.Controls.ShellSection
        {
            obj.CurrentItem = currentItem;
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ShellContent>, ValueBuilder<Microsoft.Maui.Controls.ShellContent>> buidValue)
            where T : Microsoft.Maui.Controls.ShellSection
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ShellContent>());
            if (builder.ValueIsSet()) obj.CurrentItem = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.ShellContent>, LazyValueBuilder<Microsoft.Maui.Controls.ShellContent>> buidValue)
            where T : Microsoft.Maui.Controls.ShellSection
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.ShellContent>());
            if (builder.ValueIsSet()) obj.CurrentItem = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ShellContent>, BindingBuilder<Microsoft.Maui.Controls.ShellContent>> buidBinding)
            where T : Microsoft.Maui.Controls.ShellSection
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ShellContent>(obj, Microsoft.Maui.Controls.ShellSection.CurrentItemProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Items<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellContent> items)
            where T : Microsoft.Maui.Controls.ShellSection
        {
            foreach (var item in items)
                obj.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            params Microsoft.Maui.Controls.ShellContent[] items)
            where T : Microsoft.Maui.Controls.ShellSection
        {
            foreach (var item in items)
                obj.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellContent>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellContent>>> buidValue)
            where T : Microsoft.Maui.Controls.ShellSection
        {
            var builder = buidValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellContent>>());
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