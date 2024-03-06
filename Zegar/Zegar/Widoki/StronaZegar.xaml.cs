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
                    godzinaTXT.Text = DateTime.Now.ToString("hh : mm : ss");
                });
                return true;
            });
        }
    }
}