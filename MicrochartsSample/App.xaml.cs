using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MicrochartsSample.Services;
using MicrochartsSample.Views;

namespace MicrochartsSample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<ConsumeService>();
            DependencyService.Register<IDeviceService>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
