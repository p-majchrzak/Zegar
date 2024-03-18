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
            StreamReader odczytaj = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "plik.txt"));
            List<string> listaOdczytana = new List<string>();
            if(!odczytaj.EndOfStream)
            {
                listaOdczytana.Add(odczytaj.ReadLine());
            }
            odczytaj.Close();
            lista.ItemsSource = listaOdczytana;
        }
    }
}