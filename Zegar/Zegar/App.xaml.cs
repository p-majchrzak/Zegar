using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Zegar.Widoki;

namespace Zegar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StronaWyboru();
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
