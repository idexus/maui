﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Microsoft.Maui.Controls
{
	public partial class MultiPage<T> : IList<T>
	{

        // ----- constructors -----

        // ----- collection container -----

        public int Count => this.Children.Count;
        public T this[int index] { get => this.Children[index]; set => this.Children[index] = value; }
        public bool IsReadOnly => false;
        public void Add(T item) => this.Children.Add(item);
        public void Clear() => this.Children.Clear();
        public bool Contains(T item) => this.Children.Contains(item);
        public void CopyTo(T[] array, int arrayIndex) => this.Children.CopyTo(array, arrayIndex);
        public IEnumerator<T> GetEnumerator() => this.Children.GetEnumerator();
        public int IndexOf(T item) => this.Children.IndexOf(item);
        public void Insert(int index, T item) => this.Children.Insert(index, item);
        public bool Remove(T item) => this.Children.Remove(item);
        public void RemoveAt(int index) => this.Children.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Children.GetEnumerator();

    }
}

#nullable restore
