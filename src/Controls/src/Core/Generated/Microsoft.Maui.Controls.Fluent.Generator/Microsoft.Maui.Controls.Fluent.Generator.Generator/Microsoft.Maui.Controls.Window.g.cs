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
	public partial class Window : IEnumerable
	{

        // ----- constructors -----

        public Window(out Window window) : this()
        {
            window = this;
        }

        public Window(Microsoft.Maui.Controls.Page page, out Window window) : this(page)
        {
            window = this;
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Page; }

        public void Add(Microsoft.Maui.Controls.Page? page) => this.Page = page;

    }
}

#nullable restore