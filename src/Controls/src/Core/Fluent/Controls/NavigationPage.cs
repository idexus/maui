using System.Collections;

namespace Microsoft.Maui.Controls
{
	public partial class NavigationPage : IEnumerable
	{
		public IEnumerator GetEnumerator() { yield return this.CurrentPage; }
		public void Add(Page page) => this.PushAsync(page);
	}
}