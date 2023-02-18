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
	public partial class TableView : IList<Microsoft.Maui.Controls.TableSection>
	{

        // ----- constructors -----

        public TableView(out TableView tableView) : this()
        {
            tableView = this;
        }

        public TableView(Microsoft.Maui.Controls.TableRoot root, out TableView tableView) : this(root)
        {
            tableView = this;
        }

        // ----- collection container -----

        public int Count => this.Root.Count;
        public Microsoft.Maui.Controls.TableSection this[int index] { get => this.Root[index]; set => this.Root[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.TableSection item) => this.Root.Add(item);
        public void Clear() => this.Root.Clear();
        public bool Contains(Microsoft.Maui.Controls.TableSection item) => this.Root.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.TableSection[] array, int arrayIndex) => this.Root.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.TableSection> GetEnumerator() => this.Root.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.TableSection item) => this.Root.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.TableSection item) => this.Root.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.TableSection item) => this.Root.Remove(item);
        public void RemoveAt(int index) => this.Root.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Root.GetEnumerator();

    }
}

#nullable restore