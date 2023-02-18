﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class ToolbarItemGeneratedExtension
    {
        public static T Order<T>(this T obj,
            Microsoft.Maui.Controls.ToolbarItemOrder order)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            obj.Order = order;
            return obj;
        }
        
        public static T Order<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>, ValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>> buidValue)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>());
            if (builder.ValueIsSet()) obj.Order = builder.GetValue();
            return obj;
        }
        
        public static T Order<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>, LazyValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>> buidValue)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            var builder = buidValue(new LazyValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>());
            if (builder.ValueIsSet()) obj.Order = builder.GetValue();
            return obj;
        }
        
        public static T Priority<T>(this T obj,
            int priority)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            obj.Priority = priority;
            return obj;
        }
        
        public static T Priority<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.Priority = builder.GetValue();
            return obj;
        }
        
        public static T Priority<T>(this T obj,
            System.Func<LazyValueBuilder<int>, LazyValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            var builder = buidValue(new LazyValueBuilder<int>());
            if (builder.ValueIsSet()) obj.Priority = builder.GetValue();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore