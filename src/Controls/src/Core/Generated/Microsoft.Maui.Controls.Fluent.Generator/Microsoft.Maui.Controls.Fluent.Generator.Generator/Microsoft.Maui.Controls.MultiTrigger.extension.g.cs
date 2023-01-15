﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

    public static class MultiTriggerGeneratedExtension
    {
        public static Microsoft.Maui.Controls.MultiTrigger Conditions(this Microsoft.Maui.Controls.MultiTrigger obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition> conditions)
        {
            foreach (var item in conditions)
                obj.Conditions.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.MultiTrigger Conditions(this Microsoft.Maui.Controls.MultiTrigger obj,
            params Microsoft.Maui.Controls.Condition[] conditions)
        {
            foreach (var item in conditions)
                obj.Conditions.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.MultiTrigger Conditions(this Microsoft.Maui.Controls.MultiTrigger obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>> buidValue)
        {
            var builder = buidValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                    obj.Conditions.Add(item);
            }
            return obj;
        }
        
        public static Microsoft.Maui.Controls.MultiTrigger Setters(this Microsoft.Maui.Controls.MultiTrigger obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> setters)
        {
            foreach (var item in setters)
                obj.Setters.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.MultiTrigger Setters(this Microsoft.Maui.Controls.MultiTrigger obj,
            params Microsoft.Maui.Controls.Setter[] setters)
        {
            foreach (var item in setters)
                obj.Setters.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.MultiTrigger Setters(this Microsoft.Maui.Controls.MultiTrigger obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>> buidValue)
        {
            var builder = buidValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                    obj.Setters.Add(item);
            }
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
