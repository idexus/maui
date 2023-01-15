﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class EventTriggerGeneratedExtension
    {
        public static Microsoft.Maui.Controls.EventTrigger Actions(this Microsoft.Maui.Controls.EventTrigger obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction> actions)
        {
            foreach (var item in actions)
                obj.Actions.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.EventTrigger Actions(this Microsoft.Maui.Controls.EventTrigger obj,
            params Microsoft.Maui.Controls.TriggerAction[] actions)
        {
            foreach (var item in actions)
                obj.Actions.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.EventTrigger Actions(this Microsoft.Maui.Controls.EventTrigger obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>> buidValue)
        {
            var builder = buidValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                    obj.Actions.Add(item);
            }
            return obj;
        }
        
        public static Microsoft.Maui.Controls.EventTrigger Event(this Microsoft.Maui.Controls.EventTrigger obj,
            string @event)
        {
            obj.Event = @event;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.EventTrigger Event(this Microsoft.Maui.Controls.EventTrigger obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Event = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.EventTrigger Event(this Microsoft.Maui.Controls.EventTrigger obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buidValue)
        {
            var builder = buidValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Event = builder.GetValue();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
