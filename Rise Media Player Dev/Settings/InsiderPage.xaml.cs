﻿using Rise.App.Common;
using Rise.App.Dialogs;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Rise.App.Settings
{
    public sealed partial class InsiderPage : Page
    {
        public InsiderPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
            => _ = await URLs.Insider.LaunchAsync();

        private void NavigationExpander_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InsiderWallpapers));
            SettingsDialogContainer.Breadcrumbs.
                Add(ResourceLoaders.SidebarLoader.GetString("Walls"));
        }
    }
}