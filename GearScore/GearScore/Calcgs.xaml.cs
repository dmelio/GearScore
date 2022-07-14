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
    public partial class Calcgs : ContentPage
    {
        public Calcgs()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ap.Text) && !string.IsNullOrEmpty(aap.Text) && !string.IsNullOrEmpty(dp.Text))
            {
                var AP = int.Parse(ap.Text);
                var AAP = int.Parse(aap.Text);
                var DP = int.Parse(dp.Text);

                var GS = ((AP + AAP) / 2) + DP;

                gs.Text = GS.ToString();
            }
            else
            {
                DisplayAlert("Error", "Se deben completar todos los campos", "Ok");
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            gs.Text = string.Empty;
            ap.Text = string.Empty;
            aap.Text = string.Empty;
            dp.Text = string.Empty;

        }
    }
}