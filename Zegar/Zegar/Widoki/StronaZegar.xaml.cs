using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zegar.Widoki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaZegar : ContentPage
    {
        public StronaZegar()
        {
            InitializeComponent();

            dataTXT.Text = DateTime.Now.Date.ToString("dd MMMM yyyy");

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    int godzina = DateTime.Now.Hour;
                    int minuta = DateTime.Now.Minute;
                    int sekunda = DateTime.Now.Second;

                    string godzinaTekst = "";
                    string minutaTekst = "";
                    string sekundaTekst = "";

                    if(godzina < 10)
                    {
                        godzinaTekst = "0" + godzina.ToString();
                    }
                    else
                    {
                        godzinaTekst = godzina.ToString();
                    }
                    if (minuta < 10)
                    {
                        minutaTekst = "0" + minuta.ToString();
                    }
                    else
                    {
                        minutaTekst = minuta.ToString();
                    }
                    if (sekunda < 10)
                    {
                        sekundaTekst = "0" + sekunda.ToString();
                    }
                    else
                    {
                        sekundaTekst = sekunda.ToString();
                    }
                    godzinaTXT.Text = godzinaTekst + ":" + minutaTekst + ":" + sekundaTekst;
                });
                return true;
            });
        }
    }
}