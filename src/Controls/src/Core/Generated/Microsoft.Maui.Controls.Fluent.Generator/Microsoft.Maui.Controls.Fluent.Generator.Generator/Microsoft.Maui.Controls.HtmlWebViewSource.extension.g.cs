﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class HtmlWebViewSourceGeneratedExtension
    {
        public static T BaseUrl<T>(this T obj,
            string baseUrl)
            where T : Microsoft.Maui.Controls.HtmlWebViewSource
        {
            obj.BaseUrl = baseUrl;
            return obj;
        }
        
        public static T BaseUrl<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.HtmlWebViewSource
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.BaseUrl = builder.GetValue();
            return obj;
        }
        
        public static T BaseUrl<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.HtmlWebViewSource
        {
            var builder = buidValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) obj.BaseUrl = builder.GetValue();
            return obj;
        }
        
        public static T BaseUrl<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.HtmlWebViewSource
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.HtmlWebViewSource.BaseUrlProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Html<T>(this T obj,
            string html)
            where T : Microsoft.Maui.Controls.HtmlWebViewSource
        {
            obj.Html = html;
            return obj;
        }
        
        public static T Html<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.HtmlWebViewSource
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Html = builder.GetValue();
            return obj;
        }
        
        public static T Html<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.HtmlWebViewSource
        {
            var builder = buidValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Html = builder.GetValue();
            return obj;
        }
        
        public static T Html<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.HtmlWebViewSource
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.HtmlWebViewSource.HtmlProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore