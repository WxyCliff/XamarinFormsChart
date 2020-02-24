using MicrochartsSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MicrochartsSample.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.BarChart, Title="BarChart" },
                new HomeMenuItem {Id = MenuItemType.PointChart, Title="PointChart" },
                new HomeMenuItem {Id = MenuItemType.LineChart, Title="LineChart" },
                new HomeMenuItem {Id = MenuItemType.DonutChart, Title="DonutChart" },
                new HomeMenuItem {Id = MenuItemType.CustDonutChart, Title="CustDonutChart" },
                new HomeMenuItem {Id = MenuItemType.RadialGaugeChart, Title="RadialGauge" },
                new HomeMenuItem {Id = MenuItemType.RadarChart, Title="RadarChart" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}