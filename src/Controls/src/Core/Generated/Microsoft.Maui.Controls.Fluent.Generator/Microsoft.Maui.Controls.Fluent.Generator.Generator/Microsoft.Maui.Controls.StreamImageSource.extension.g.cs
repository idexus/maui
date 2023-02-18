﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class StreamImageSourceGeneratedExtension
    {
        public static T Stream<T>(this T obj,
            System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>> stream)
            where T : Microsoft.Maui.Controls.StreamImageSource
        {
            obj.Stream = stream;
            return obj;
        }
        
        public static T Stream<T>(this T obj,
            System.Func<ValueBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>, ValueBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>> buidValue)
            where T : Microsoft.Maui.Controls.StreamImageSource
        {
            var builder = buidValue(new ValueBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>());
            if (builder.ValueIsSet()) obj.Stream = builder.GetValue();
            return obj;
        }
        
        public static T Stream<T>(this T obj,
            System.Func<LazyValueBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>, LazyValueBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>> buidValue)
            where T : Microsoft.Maui.Controls.StreamImageSource
        {
            var builder = buidValue(new LazyValueBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>());
            if (builder.ValueIsSet()) obj.Stream = builder.GetValue();
            return obj;
        }
        
        public static T Stream<T>(this T obj,
            System.Func<BindingBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>, BindingBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>> buidBinding)
            where T : Microsoft.Maui.Controls.StreamImageSource
        {
            var builder = buidBinding(new BindingBuilder<System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>>(obj, Microsoft.Maui.Controls.StreamImageSource.StreamProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore