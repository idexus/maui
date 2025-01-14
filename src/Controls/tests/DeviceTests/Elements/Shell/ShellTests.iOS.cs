﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Platform;
using UIKit;
using Xunit;

namespace Microsoft.Maui.DeviceTests
{
	[Category(TestCategory.Shell)]
	public partial class ShellTests
	{
		protected Task CheckFlyoutState(ShellRenderer renderer, bool result) =>
			throw new NotImplementedException();

		[Fact(DisplayName = "Swiping Away Modal Propagates to Shell")]
		public async Task SwipingAwayModalPropagatesToShell()
		{
			SetupBuilder();
			var shell = await CreateShellAsync((shell) =>
			{
				shell.Items.Add(new ContentPage());
			});

			await CreateHandlerAndAddToWindow<ShellRenderer>(shell, async (handler) =>
			{
				var modalPage = new ContentPage();
				modalPage.On<iOS>().SetModalPresentationStyle(Controls.PlatformConfiguration.iOSSpecific.UIModalPresentationStyle.FormSheet);
				var platformWindow = MauiContext.GetPlatformWindow().RootViewController;

				await shell.Navigation.PushModalAsync(modalPage);

				var modalVC = GetModalWrapper(modalPage);
				int navigatedFired = 0;
				ShellNavigationSource? shellNavigationSource = null;
				var finishedNavigation = new TaskCompletionSource<bool>();
				shell.Navigated += ShellNavigated;

				modalVC.DidDismiss(null);
				await finishedNavigation.Task.WaitAsync(TimeSpan.FromSeconds(2));
				Assert.Equal(1, navigatedFired);
				Assert.Equal(ShellNavigationSource.PopToRoot, shellNavigationSource.Value);

				Assert.Equal(0, shell.Navigation.ModalStack.Count);

				void ShellNavigated(object sender, ShellNavigatedEventArgs e)
				{
					navigatedFired++;
					shellNavigationSource = e.Source;
					finishedNavigation.SetResult(true);
				}
			});
		}

		[Fact(DisplayName = "Swiping Away Modal Removes Entire Navigation Page")]
		public async Task SwipingAwayModalRemovesEntireNavigationPage()
		{
			Routing.RegisterRoute(nameof(SwipingAwayModalRemovesEntireNavigationPage), typeof(ModalShellPage));

			SetupBuilder();
			var shell = await CreateShellAsync((shell) =>
			{
				shell.Items.Add(new ContentPage());
			});

			await CreateHandlerAndAddToWindow<ShellRenderer>(shell, async (handler) =>
			{
				var modalPage = new Controls.NavigationPage(new ContentPage());
				modalPage.On<iOS>().SetModalPresentationStyle(Controls.PlatformConfiguration.iOSSpecific.UIModalPresentationStyle.FormSheet);
				var platformWindow = MauiContext.GetPlatformWindow().RootViewController;

				await shell.Navigation.PushModalAsync(modalPage);
				await shell.GoToAsync(nameof(SwipingAwayModalRemovesEntireNavigationPage));
				await shell.GoToAsync(nameof(SwipingAwayModalRemovesEntireNavigationPage));
				await shell.GoToAsync(nameof(SwipingAwayModalRemovesEntireNavigationPage));

				var modalVC = GetModalWrapper(modalPage);
				int navigatedFired = 0;
				ShellNavigationSource? shellNavigationSource = null;
				var finishedNavigation = new TaskCompletionSource<bool>();
				shell.Navigated += ShellNavigated;

				modalVC.DidDismiss(null);
				await finishedNavigation.Task.WaitAsync(TimeSpan.FromSeconds(2));
				Assert.Equal(1, navigatedFired);
				Assert.Equal(ShellNavigationSource.PopToRoot, shellNavigationSource.Value);
				Assert.Equal(0, shell.Navigation.ModalStack.Count);

				void ShellNavigated(object sender, ShellNavigatedEventArgs e)
				{
					navigatedFired++;
					shellNavigationSource = e.Source;
					finishedNavigation.SetResult(true);
				}
			});
		}

		[Fact(DisplayName = "Clicking BackButton Fires Correct Navigation Events")]
		public async Task ShellWithFlyoutDisabledDoesntRenderFlyout()
		{
			SetupBuilder();
			var shell = await CreateShellAsync((shell) =>
			{
				shell.Items.Add(new ContentPage());
			});


			await CreateHandlerAndAddToWindow<ShellRenderer>(shell, async (handler) =>
			{
				var secondPage = new ContentPage();
				await shell.Navigation.PushAsync(new ContentPage())
					.WaitAsync(TimeSpan.FromSeconds(2));

				IShellContext shellContext = handler;
				var sectionRenderer = (shellContext.CurrentShellItemRenderer as ShellItemRenderer)
					.CurrentRenderer as ShellSectionRenderer;

				int navigatingFired = 0;
				int navigatedFired = 0;
				var finishedNavigation = new TaskCompletionSource<bool>();
				ShellNavigationSource? shellNavigationSource = null;

				shell.Navigating += ShellNavigating;
				shell.Navigated += ShellNavigated;
				sectionRenderer.SendPop();
				await finishedNavigation.Task.WaitAsync(TimeSpan.FromSeconds(2));
				Assert.Equal(1, navigatingFired);
				Assert.Equal(1, navigatedFired);
				Assert.Equal(ShellNavigationSource.PopToRoot, shellNavigationSource.Value);

				void ShellNavigated(object sender, ShellNavigatedEventArgs e)
				{
					navigatedFired++;
					shellNavigationSource = e.Source;
					finishedNavigation.SetResult(true);
				}

				void ShellNavigating(object sender, ShellNavigatingEventArgs e)
				{
					navigatingFired++;
				}
			});
		}

		[Fact(DisplayName = "Cancel BackButton Navigation")]
		public async Task CancelBackButtonNavigation()
		{
			SetupBuilder();
			var shell = await CreateShellAsync((shell) =>
			{
				shell.Items.Add(new ContentPage());
			});


			await CreateHandlerAndAddToWindow<ShellRenderer>(shell, async (handler) =>
			{
				var secondPage = new ContentPage();
				await shell.Navigation.PushAsync(new ContentPage())
					.WaitAsync(TimeSpan.FromSeconds(2));

				IShellContext shellContext = handler;
				var sectionRenderer = (shellContext.CurrentShellItemRenderer as ShellItemRenderer)
					.CurrentRenderer as ShellSectionRenderer;

				int navigatingFired = 0;
				int navigatedFired = 0;
				ShellNavigationSource? shellNavigationSource = null;

				shell.Navigating += ShellNavigating;
				shell.Navigated += ShellNavigated;
				var finishedNavigation = new TaskCompletionSource<bool>();
				sectionRenderer.SendPop();

				// Give Navigated time to fire just in case
				await Task.Delay(100);
				Assert.Equal(1, navigatingFired);
				Assert.Equal(0, navigatedFired);
				Assert.False(shellNavigationSource.HasValue);

				void ShellNavigated(object sender, ShellNavigatedEventArgs e)
				{
					navigatedFired++;
				}

				void ShellNavigating(object sender, ShellNavigatingEventArgs e)
				{
					navigatingFired++;
					e.Cancel();
				}
			});
		}

		async Task TapToSelect(ContentPage page)
		{
			var shellContent = page.Parent as ShellContent;
			var shellSection = shellContent.Parent as ShellSection;
			var shellItem = shellSection.Parent as ShellItem;
			var shell = shellItem.Parent as Shell;
			await OnNavigatedToAsync(shell.CurrentPage);

			if (shellItem != shell.CurrentItem)
				throw new NotImplementedException();

			if (shellSection != shell.CurrentItem.CurrentItem)
				throw new NotImplementedException();

			var pagerParent = (shell.CurrentPage.Handler as IPlatformViewHandler)
				.PlatformView.FindParent(x => x.NextResponder is UITabBarController);

			var tabController = pagerParent.NextResponder as ShellItemRenderer;

			var section = tabController.SelectedViewController as ShellSectionRenderer;

			var rootCV = section.ViewControllers[0] as
				ShellSectionRootRenderer;

			var rootHeader = rootCV.ChildViewControllers
				.OfType<ShellSectionRootHeader>()
				.First();

			var newIndex = shellSection.Items.IndexOf(shellContent);

			await Task.Delay(100);

			rootHeader.ItemSelected(rootHeader.CollectionView, NSIndexPath.FromItemSection((int)newIndex, 0));

			await OnNavigatedToAsync(page);
		}

		class ModalShellPage : ContentPage
		{
			public ModalShellPage()
			{
				Shell.SetPresentationMode(this, PresentationMode.ModalAnimated);
			}
		}
	}
}
