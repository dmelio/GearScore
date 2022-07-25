using GearScore.Model;
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
    public partial class Crons : ContentPage
    {
        public IList<CronList> Crones {get;set;}
        public Crons()
        {
            InitializeComponent();
            Crones = new List<CronList>();
            Crones.Add(new CronList
            {
                Nombre = "BlackStar Armor",
                Base = 0,
                Pri = 0,
                Duo = 220,
                Tri = 680,
                Tet = 1350
            });
            Crones.Add(new CronList
            {
                Nombre = "Yelmo Labreska",
                Base = 0,
                Pri = 1500,
                Duo = 2100,
                Tri = 2700,
                Tet = 4000
            });
            Crones.Add(new CronList
            {
                Nombre = "Dios Muerto",
                Base = 0,
                Pri = 1500,
                Duo = 2100,
                Tri = 2700,
                Tet = 4000
            });
            Crones.Add(new CronList
            {
                Nombre = "Hebetate/Urgon",
                Base = 0,
                Pri = 0,
                Duo = 43,
                Tri = 131,
                Tet = 493
            });
            Crones.Add(new CronList
            {
                Nombre = "Nariz roja/Muskan/Bheg/Livre/Giath/Grifo",
                Base = 0,
                Pri = 0,
                Duo = 38,
                Tri = 114,
                Tet = 429
            });
            Crones.Add(new CronList
            {
                Nombre = "Tuvala (Armadura/Guantes/Botas/Yelmo/Principal/Secundaria)",
                Base = 0,
                Pri = 0,
                Duo = 25,
                Tri = 75,
                Tet = 165
            });
            Crones.Add(new CronList
            {
                Nombre = "Blackstar (Guantes/Botas/Yelmo)",
                Base = 0,
                Pri = 0,
                Duo = 190,
                Tri = 570,
                Tet = 980
            });
            Crones.Add(new CronList
            {
                Nombre = "Godr Principal",
                Base = 0,
                Pri = 0,
                Duo = 620,
                Tri = 980,
                Tet = 1820
            });
            Crones.Add(new CronList
            {
                Nombre = "Blackstar Principal",
                Base = 0,
                Pri = 0,
                Duo = 100,
                Tri = 591,
                Tet = 3670
            });
            Crones.Add(new CronList
            {
                Nombre = "Kzarka/Offin Tett",
                Base = 0,
                Pri = 0,
                Duo = 34,
                Tri = 127,
                Tet = 531
            });
            Crones.Add(new CronList
            {
                Nombre = "Godr Despertar",
                Base = 0,
                Pri = 0,
                Duo = 620,
                Tri = 980,
                Tet = 1820
            });
            Crones.Add(new CronList
            {
                Nombre = "Blackstar Despertar",
                Base = 0,
                Pri = 0,
                Duo = 100,
                Tri = 591,
                Tet = 3670
            });
            Crones.Add(new CronList
            {
                Nombre = "Dandelion",
                Base = 0,
                Pri = 0,
                Duo = 40,
                Tri = 146,
                Tet = 611
            });
            Crones.Add(new CronList
            {
                Nombre = "Cazadragones",
                Base = 0,
                Pri = 0,
                Duo = 34,
                Tri = 127,
                Tet = 531
            });
            Crones.Add(new CronList
            {
                Nombre = "Tuvala Despertar",
                Base = 0,
                Pri = 0,
                Duo = 30,
                Tri = 85,
                Tet = 180
            });
            Crones.Add(new CronList
            {
                Nombre = "Godr Secundaria",
                Base = 0,
                Pri = 0,
                Duo = 620,
                Tri = 980,
                Tet = 1820
            });
            Crones.Add(new CronList
            {
                Nombre = "Blackstar Secundaria",
                Base = 0,
                Pri = 0,
                Duo = 100,
                Tri = 591,
                Tet = 3670
            });
            Crones.Add(new CronList
            {
                Nombre = "Kutum/Nouver",
                Base = 0,
                Pri = 0,
                Duo = 34,
                Tri = 127,
                Tet = 531
            });
            Crones.Add(new CronList
            {
                Nombre = "Tungrad (Anillo/Collar/Cinturon)",
                Base = 62,
                Pri = 187,
                Duo = 562,
                Tri = 1562,
                Tet = 7499
            });
            Crones.Add(new CronList
            {
                Nombre = "Arete Tungrad",
                Base = 47,
                Pri = 142,
                Duo = 427,
                Tri = 1187,
                Tet = 5699
            });
            Crones.Add(new CronList
            {
                Nombre = "Pupila de las ruinas",
                Base = 37,
                Pri = 112,
                Duo = 337,
                Tri = 937,
                Tet = 4499
            });
            Crones.Add(new CronList
            {
                Nombre = "Ronaros del bosque",
                Base = 18,
                Pri = 56,
                Duo = 168,
                Tri = 468,
                Tet = 2249
            });
            Crones.Add(new CronList
            {
                Nombre = "Amenaza inminente",
                Base = 62,
                Pri = 187,
                Duo = 562,
                Tri = 1562,
                Tet = 7499
            });
            Crones.Add(new CronList
            {
                Nombre = "Cadry / Crescent",
                Base = 24,
                Pri = 74,
                Duo = 224,
                Tri = 625,
                Tet = 2999
            });
            Crones.Add(new CronList
            {
                Nombre = "Tuvala (Anillo/Collar/Cinturon/arete)",
                Base = 10,
                Pri = 20,
                Duo = 40,
                Tri = 60,
                Tet = 120
            });
            Crones.Add(new CronList
            {
                Nombre = "Erosion negra / Aurora / Vaha's",
                Base = 62,
                Pri = 187,
                Duo = 562,
                Tri = 1562,
                Tet = 7499
            });
            Crones.Add(new CronList
            {
                Nombre = "Narc",
                Base = 37,
                Pri = 112,
                Duo = 337,
                Tri = 937,
                Tet = 4499
            });
            Crones.Add(new CronList
            {
                Nombre = "Arete de la ilusion",
                Base = 47,
                Pri = 142,
                Duo = 427,
                Tri = 1187,
                Tet = 5699
            });
            Crones.Add(new CronList
            {
                Nombre = "Deboreka",
                Base = 95,
                Pri = 228,
                Duo = 865,
                Tri = 2405,
                Tet = 11548
            });
            Crones.Add(new CronList
            {
                Nombre = "Layten / Ogro",
                Base = 47,
                Pri = 142,
                Duo = 427,
                Tri = 1187,
                Tet = 5699
            });
            Crones.Add(new CronList
            {
                Nombre = "Luna despierta / Rio Despierto",
                Base = 62,
                Pri = 187,
                Duo = 562,
                Tri = 1562,
                Tet = 7499
            });
            Crones.Add(new CronList
            {
                Nombre = "Basilisko / Centauro",
                Base = 37,
                Pri = 112,
                Duo = 337,
                Tri = 937,
                Tet = 4499
            });
            Crones.Add(new CronList
            {
                Nombre = "Orkinrad",
                Base = 47,
                Pri = 142,
                Duo = 427,
                Tri = 1187,
                Tet = 5699
            });
            Crones.Add(new CronList
            {
                Nombre = "Cinturon de turos",
                Base = 62,
                Pri = 187,
                Duo = 562,
                Tri = 1562,
                Tet = 7499
            });

            BindingContext = this;
        }

        private void Itemcronpick_SelectedIndexChanged(object sender, EventArgs e)
        {   
            var itempick = Itemcronpick.SelectedItem as CronList;
            itembase.Text = itempick.Base.ToString();
            itemPri.Text = itempick.Pri.ToString();
            itemDuo.Text = itempick.Duo.ToString();
            itemTri.Text = itempick.Tri.ToString();
            itemTet.Text = itempick.Tet.ToString();
        }
    }
}