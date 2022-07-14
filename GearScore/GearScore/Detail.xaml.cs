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
            var htmlcontent = new HtmlWebViewSource();
            htmlcontent.Html = "<html><head></head><body>" +
                "<a>Videito<a><br> " +
                "<iframe src='https://www.youtube.com/embed/3xmr1JnexIc' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe></body></html>";
            Video.Source = htmlcontent;
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