using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MicrochartsSample.Models;

namespace MicrochartsSample.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.BarChart:
                        MenuPages.Add(id, new NavigationPage(new BarChartPage()));
                        break;
                    case (int)MenuItemType.PointChart:
                        MenuPages.Add(id, new NavigationPage(new PointChartPage()));
                        break;
                    case (int)MenuItemType.LineChart:
                        MenuPages.Add(id, new NavigationPage(new LineChartPage()));
                        break;
                    case (int)MenuItemType.DonutChart:
                        MenuPages.Add(id, new NavigationPage(new DonutChartPage()));
                        break;
                    case (int)MenuItemType.CustDonutChart:
                        MenuPages.Add(id, new NavigationPage(new CustDonutChartPage()));
                        break;
                    case (int)MenuItemType.RadialGaugeChart:
                        MenuPages.Add(id, new NavigationPage(new RadialGaugeChartPage()));
                        break;
                    case (int)MenuItemType.RadarChart:
                        MenuPages.Add(id, new NavigationPage(new RadarChartPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}