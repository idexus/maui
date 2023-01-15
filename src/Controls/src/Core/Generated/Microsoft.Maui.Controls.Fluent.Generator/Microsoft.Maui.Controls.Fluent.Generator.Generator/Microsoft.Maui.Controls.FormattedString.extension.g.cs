﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class FormattedStringGeneratedExtension
    {
        public static T Spans<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Span> spans)
            where T : Microsoft.Maui.Controls.FormattedString
        {
            foreach (var item in spans)
                obj.Spans.Add(item);
            return obj;
        }

        public static T Spans<T>(this T obj,
            params Microsoft.Maui.Controls.Span[] spans)
            where T : Microsoft.Maui.Controls.FormattedString
        {
            foreach (var item in spans)
                obj.Spans.Add(item);
            return obj;
        }

        public static T Spans<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Span>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Span>>> buidValue)
            where T : Microsoft.Maui.Controls.FormattedString
        {
            var builder = buidValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Span>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                    obj.Spans.Add(item);
            }
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
