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
	public partial class SwipeItemView : IEnumerable
	{

        // ----- constructors -----

        public SwipeItemView() { }

        public SwipeItemView(out SwipeItemView swipeItemView) : this()
        {
            swipeItemView = this;
        }

        // ----- single item container -----

        public new IEnumerator GetEnumerator() { yield return this.Content; }

        public new void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

    }
}

#nullable restore
