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
    public partial class StronaMinutnik : ContentPage
    {
        decimal iloscCzasu, iloscCzasuDoKonca = 0;
        public StronaMinutnik()
        {
            InitializeComponent();
        }

        private void StartBTN_Clicked(object sender, EventArgs e)
        {
            iloscCzasu = int.Parse(czasTP.Text) * 60;
            LiczCzas();
        }
        public void LiczCzas()
        {
            Device.StartTimer(new TimeSpan(0, 0, 0, 1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    if (iloscCzasu < iloscCzasuDoKonca)
                    {
                        DisplayAlert("Informacja", "Czas minął!", "Ok");
                    }
                    liczonyCzasTXT.Text = Math.Floor(iloscCzasuDoKonca / 60).ToString() + ":" + iloscCzasuDoKonca.ToString();
                    iloscCzasuDoKonca++;
                });
                if (iloscCzasu < iloscCzasuDoKonca)
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