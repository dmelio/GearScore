using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GearScore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Brackets : ContentPage
    {
        public Brackets()
        {
            InitializeComponent();
        }

        private void Button_Clickeddp(object sender, EventArgs e)
        {
            GridAP.IsVisible = false;
            GridDP.IsVisible = true;
        }

        private void Button_Clickedap(object sender, EventArgs e)
        {
            GridAP.IsVisible = true;
            GridDP.IsVisible = false;
        }
    }
}