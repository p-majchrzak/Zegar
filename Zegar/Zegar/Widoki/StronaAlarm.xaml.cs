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
            LiczCzas();
        }
        public void LiczCzas()
        {
            Device.StartTimer(new TimeSpan(0, 0, 0, 0, 1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    if(DateTime.Now.ToString("hh:mm") == czasTP.Time.ToString().Substring(0, czasTP.Time.ToString().Length - 3))
                    {
                        DisplayAlert("Informacja", "Alarm!", "Ok");
                    }
                });
                if (DateTime.Now.ToString("hh:mm") == czasTP.Time.ToString().Substring(0, czasTP.Time.ToString().Length - 3))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            });
        }
    }
}