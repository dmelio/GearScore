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
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();
        }
        private void btncapmenu_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Caphras());
        }

        private void btncronmenu_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Crons());
        }

        private void btnbramenu_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Brackets());
        }

        private  void btncalcgs_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Calcgs());
        }
    }
}