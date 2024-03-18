using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zegar.Widoki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZapisanyCzas : ContentPage
    {
        public ZapisanyCzas()
        {
            InitializeComponent();
            Odczyt();
        }
        public void Odczyt()
        {
            string sciezka = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "plikTekstowy.txt");
            if(File.Exists(sciezka))
            {
                StreamReader odczytaj = new StreamReader(sciezka);
                List<string> listaOdczytana = new List<string>();
                while (!odczytaj.EndOfStream)
                {
                    listaOdczytana.Add(odczytaj.ReadLine());
                }
                odczytaj.Close();
                lista.ItemsSource = listaOdczytana;
            }
        }
    }
}