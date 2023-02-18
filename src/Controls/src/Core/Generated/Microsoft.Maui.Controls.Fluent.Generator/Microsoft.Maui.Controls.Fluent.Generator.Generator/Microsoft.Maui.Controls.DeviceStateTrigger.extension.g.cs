﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class DeviceStateTriggerGeneratedExtension
    {
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            string device)
        {
            obj.Device = device;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Device = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buidValue)
        {
            var builder = buidValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Device = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore