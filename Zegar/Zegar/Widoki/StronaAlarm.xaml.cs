using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zegar.Widoki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaAlarm : ContentPage
    {
        public StronaAlarm()
        {
            InitializeComponent();
        }

        private void UstawAlarmBTN_Clicked(object sender, EventArgs e)
        {
            long liczba = czasTP.Time.Seconds - DateTime.Now.Second;
            DisplayAlert(liczba.ToString(), liczba.ToString(), liczba.ToString());
        }
        public void LiczCzas()
        {
            Device.StartTimer(new TimeSpan(0, 0, 0, 0, 1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {

                });
                return true;
            });
        }
    }
}