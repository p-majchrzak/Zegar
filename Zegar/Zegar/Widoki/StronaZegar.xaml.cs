using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        public string godzina = "";
        public StronaZegar()
        {
            InitializeComponent();
            Start();
            
        }
        void Start()
        {
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    dataTXT.Text = DateTime.Now.Date.ToString("dd MMMM yyyy");
                    godzinaTXT.Text = DateTime.Now.ToString("hh : mm : ss");
                    godzina = godzinaTXT.Text;
                });
                return true;
            });
        }
        private void Zapisz_Clicked(object sender, EventArgs e)
        {
            StreamWriter zapis = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "plikTekstowy.txt"),true);
            zapis.WriteLine(godzina);
            zapis.Close();
        }

        private void PokazZapisane_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ZapisanyCzas());
        }
    }
}