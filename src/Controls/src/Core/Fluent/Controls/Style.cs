using System;
using System.Linq;
using Microsoft.Maui.Controls.Fluent;

namespace Microsoft.Maui.Controls
{
	[FluentInterface]
	public partial class Style
	{
		VisualStateGroupList GetVisualStateGroupList()
		{
			Microsoft.Maui.Controls.VisualStateGroupList? groupList = null;
			var groupListSetter = Setters.FirstOrDefault(e => e.Property == VisualStateManager.VisualStateGroupsProperty);
			if (groupListSetter != null)
			{
				groupList = groupListSetter.Value as VisualStateGroupList;
			}
			if (groupList == null)
			{
				groupList = new VisualStateGroupList();
				var setter = new Setter { Property = VisualStateManager.VisualStateGroupsProperty, Value = groupList };
				this.Setters.Add(setter);
			}
			return groupList;
		}

		VisualStateGroup GetCommonStatesVisualStateGroup(VisualStateGroupList visualStateGroupList)
		{
			var visualStateGroup = visualStateGroupList.FirstOrDefault(e => e.Name.Equals(VisualStateGroup.CommonStates, StringComparison.Ordinal));
			if (visualStateGroup == null)
			{
				visualStateGroup = new VisualStateGroup(VisualStateGroup.CommonStates);
				visualStateGroupList.Add(visualStateGroup);
			}
			return visualStateGroup;
		}

		public void Add(Trigger trigger) => this.Triggers.Add(trigger);
		public void Add(DataTrigger trigger) => this.Triggers.Add(trigger);
		public void Add(VisualStateGroupList groupList)
		{
			var setter = new Setter { Property = VisualStateManager.VisualStateGroupsProperty, Value = groupList };
			this.Setters.Add(setter);
		}

		public void Add(VisualStateGroup group)
		{
			GetVisualStateGroupList().Add(group);
		}

		public void Add(VisualState visualState)
		{
			var visualStateGroupList = GetVisualStateGroupList();
			GetCommonStatesVisualStateGroup(visualStateGroupList).Add(visualState);
		}
	}
}

