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

        }
    }
}