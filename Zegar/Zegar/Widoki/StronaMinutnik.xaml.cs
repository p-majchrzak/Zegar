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
        public StronaMinutnik()
        {
            InitializeComponent();
        }

        private void StartBTN_Clicked(object sender, EventArgs e)
        {

        }
    }
}