﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Microsoft.Maui.Controls
{
	using Microsoft.Maui.Controls.Fluent;

	[FluentInterface]
	public partial class ContentView : IEnumerable
	{

        // ----- constructors -----

        public ContentView() { }

        public ContentView(out ContentView contentView) : this()
        {
            contentView = this;
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

    }
}

#nullable restore
