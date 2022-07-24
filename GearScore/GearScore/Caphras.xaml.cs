using GearScore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GearScore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Caphras : ContentPage
    {
        public IList<Hebepen> HebesV { get; set; }
        public IList<LivreV> LivreVs { get; set; }
        public IList<DandeV> DandesV { get; set; }
        public IList<PrimariaV> PrimariasV { get; set; }
        public IList<SecundariaV> SecundariasV { get; set; }


        public IList<Item> Items { get; set; }
        public Caphras()
        {
            InitializeComponent();
            SecundariasV = new List<SecundariaV>();
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 0",
                NvlEncant = 0,
                CantCap = 0
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 1",
                NvlEncant = 1,
                CantCap = 297
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 2",
                NvlEncant = 2,
                CantCap = 686
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 3",
                NvlEncant = 3,
                CantCap = 1167
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 4",
                NvlEncant = 4,
                CantCap = 1740
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 5",
                NvlEncant = 5,
                CantCap = 2645
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 6",
                NvlEncant = 6,
                CantCap = 3665
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 7",
                NvlEncant = 7,
                CantCap = 4800
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 8",
                NvlEncant = 8,
                CantCap = 6050
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 9",
                NvlEncant = 9,
                CantCap = 7415
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 10",
                NvlEncant = 10,
                CantCap = 8895
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Secundaria V Nvl 11",
                NvlEncant = 11,
                CantCap = 10417
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 12",
                NvlEncant = 12,
                CantCap = 12054
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 13",
                NvlEncant = 13,
                CantCap = 13806
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 14",
                NvlEncant = 14,
                CantCap = 15673
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 15",
                NvlEncant = 15,
                CantCap = 17655
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 16",
                NvlEncant = 16,
                CantCap = 19752
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 17",
                NvlEncant = 17,
                CantCap = 21964
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 18",
                NvlEncant = 18,
                CantCap = 24291
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 19",
                NvlEncant = 19,
                CantCap = 26733
            });
            SecundariasV.Add(new SecundariaV
            {
                Nombre = "Nvl 20",
                NvlEncant = 20,
                CantCap = 29403
            });


            PrimariasV = new List<PrimariaV>();
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 0",
                NvlEncant = 0,
                CantCap = 0
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 1",
                NvlEncant = 1,
                CantCap = 297
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 2",
                NvlEncant = 2,
                CantCap = 686
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 3",
                NvlEncant = 3,
                CantCap = 1167
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 4",
                NvlEncant = 4,
                CantCap = 1740
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 5",
                NvlEncant = 5,
                CantCap = 2645
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 6",
                NvlEncant = 6,
                CantCap = 3665
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 7",
                NvlEncant = 7,
                CantCap = 4800
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 8",
                NvlEncant = 8,
                CantCap = 6050
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 9",
                NvlEncant = 9,
                CantCap = 7415
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 10",
                NvlEncant = 10,
                CantCap = 8895
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 11",
                NvlEncant = 11,
                CantCap = 10417
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 12",
                NvlEncant = 12,
                CantCap = 12054
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 13",
                NvlEncant = 13,
                CantCap = 13806
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 14",
                NvlEncant = 14,
                CantCap = 15673
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 15",
                NvlEncant = 15,
                CantCap = 17655
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 16",
                NvlEncant = 16,
                CantCap = 19752
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 17",
                NvlEncant = 17,
                CantCap = 21964
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 18",
                NvlEncant = 18,
                CantCap = 24291
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 19",
                NvlEncant = 19,
                CantCap = 26733
            });
            PrimariasV.Add(new PrimariaV
            {
                Nombre = "Nvl 20",
                NvlEncant = 20,
                CantCap = 29403
            });


            DandesV = new List<DandeV>();
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 0",
                NvlEncant = 0,
                CantCap = 0
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 1",
                NvlEncant = 1,
                CantCap = 345
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 2",
                NvlEncant = 2,
                CantCap = 796
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 3",
                NvlEncant = 3,
                CantCap = 1352
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 4",
                NvlEncant = 4,
                CantCap = 2014
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 5",
                NvlEncant = 5,
                CantCap = 3058
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 6",
                NvlEncant = 6,
                CantCap = 4234
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 7",
                NvlEncant = 7,
                CantCap = 5542
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 8",
                NvlEncant = 8,
                CantCap = 6982
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 9",
                NvlEncant = 9,
                CantCap = 8555
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 10",
                NvlEncant = 10,
                CantCap = 10260
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 11",
                NvlEncant = 11,
                CantCap = 12012
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 12",
                NvlEncant = 12,
                CantCap = 13896
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 13",
                NvlEncant = 13,
                CantCap = 15912
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 14",
                NvlEncant = 14,
                CantCap = 18060
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 15",
                NvlEncant = 15,
                CantCap = 20340
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 16",
                NvlEncant = 16,
                CantCap = 22752
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 17",
                NvlEncant = 17,
                CantCap = 25296
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 18",
                NvlEncant = 18,
                CantCap = 27972
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 19",
                NvlEncant = 19,
                CantCap = 30780
            });
            DandesV.Add(new DandeV
            {
                Nombre = "Nvl 20",
                NvlEncant = 20,
                CantCap = 33768
            });

            LivreVs = new List<LivreV>();
            LivreVs.Add(new LivreV
                {
                Nombre = "Nvl 0",
                NvlEncant = 0,
                CantCap = 0
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 1",
                NvlEncant = 1,
                CantCap = 153
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 2",
                NvlEncant = 2,
                CantCap = 383
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 3",
                NvlEncant = 3,
                CantCap = 690
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 4",
                NvlEncant = 4,
                CantCap = 997
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 5",
                NvlEncant = 5,
                CantCap = 1710
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 6",
                NvlEncant = 6,
                CantCap = 2424
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 7",
                NvlEncant = 7,
                CantCap = 3522
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 8",
                NvlEncant = 8,
                CantCap = 4716
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 9",
                NvlEncant = 9,
                CantCap = 5950
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 10",
                NvlEncant = 10,
                CantCap = 7224
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 11",
                NvlEncant = 11,
                CantCap = 8496
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 12",
                NvlEncant = 12,
                CantCap = 9808
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 13",
                NvlEncant = 13,
                CantCap = 11160
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 14",
                NvlEncant = 14,
                CantCap = 12552
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 15",
                NvlEncant = 15,
                CantCap = 13984
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 16",
                NvlEncant = 16,
                CantCap = 15456
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 17",
                NvlEncant = 17,
                CantCap = 16968
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 18",
                NvlEncant = 18,
                CantCap = 18520
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 19",
                NvlEncant = 19,
                CantCap = 20112
            });
            LivreVs.Add(new LivreV
            {
                Nombre = "Nvl 20",
                NvlEncant = 20,
                CantCap = 21744
            });

            Items = new List<Item>();
            Items.Add(new Item
            {
                Nombreitem ="Hebetate V"
            });
            Items.Add(new Item
            {
                Nombreitem = "Armadura Boss V (No hebe)"
            });
            Items.Add(new Item
            {
                Nombreitem = "Dandelion V"

            }); 
            Items.Add(new Item
            {
                Nombreitem = "Arma principal V"
            });
            Items.Add(new Item
            {
                Nombreitem = "Arma Secundaria V"
            });

            HebesV = new List<Hebepen>();
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 0",
                NvlEncant = 0,
                CantCap = 0
            });
            HebesV.Add(new Hebepen
            {
                Nombre="Nvl 1",
                NvlEncant= 1,
                CantCap = 176
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 2",
                NvlEncant = 2,
                CantCap = 440
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 3",
                NvlEncant = 3,
                CantCap = 792
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 4",
                NvlEncant = 4,
                CantCap = 1144
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 5",
                NvlEncant = 5,
                CantCap = 1961
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 6",
                NvlEncant = 6,
                CantCap = 2778
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 7",
                NvlEncant = 7,
                CantCap = 4036
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 8",
                NvlEncant = 8,
                CantCap = 5404
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 9",
                NvlEncant = 9,
                CantCap = 6812
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 10",
                NvlEncant = 10,
                CantCap = 8260
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 11",
                NvlEncant = 11,
                CantCap = 9700
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 12",
                NvlEncant = 12,
                CantCap = 11180
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 13",
                NvlEncant = 13,
                CantCap = 12700
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 14",
                NvlEncant = 14,
                CantCap = 14260
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 15",
                NvlEncant = 15,
                CantCap = 15860
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 16",
                NvlEncant = 16,
                CantCap = 17500
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 17",
                NvlEncant = 17,
                CantCap = 19180
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 18",
                NvlEncant = 18,
                CantCap = 20900
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 19",
                NvlEncant = 19,
                CantCap = 22660
            });
            HebesV.Add(new Hebepen
            {
                Nombre = "Nvl 20",
                NvlEncant = 20,
                CantCap = 24460
            });
            BindingContext = this;
        }
        private void btncalccap_Clicked(object sender, EventArgs e)
        {
            if (pickitembase.SelectedItem != null || pickitemobj.SelectedItem !=null)
            {
                var itemselec = Listitems.SelectedItem as Item;
                if (itemselec.Nombreitem =="Hebetate V")
                {
                    var capbase = pickitembase.SelectedItem as Hebepen;
                    var capobj = pickitemobj.SelectedItem as Hebepen;
                    var Totalcap = capobj.CantCap - capbase.CantCap;
                    calccap.Text = Totalcap.ToString();
                }
                else
                {
                    if (itemselec.Nombreitem == "Armadura Boss V (No hebe)")
                    {
                        var capbase = pickitembase.SelectedItem as LivreV;
                        var capobj = pickitemobj.SelectedItem as LivreV;
                        var Totalcap = capobj.CantCap - capbase.CantCap;
                        calccap.Text = Totalcap.ToString();
                    }
                    else
                    {
                        if (itemselec.Nombreitem == "Dandelion V")
                        {
                            var capbase = pickitembase.SelectedItem as DandeV;
                            var capobj = pickitemobj.SelectedItem as DandeV;
                            var Totalcap = capobj.CantCap - capbase.CantCap;
                            calccap.Text = Totalcap.ToString();
                        }
                        else
                        {
                            if (itemselec.Nombreitem == "Arma principal V")
                            {
                                var capbase = pickitembase.SelectedItem as PrimariaV;
                                var capobj = pickitemobj.SelectedItem as PrimariaV;
                                var Totalcap = capobj.CantCap - capbase.CantCap;
                                calccap.Text = Totalcap.ToString();
                            }
                            else
                            {
                                if (itemselec.Nombreitem == "Arma Secundaria V")
                                {
                                    var capbase = pickitembase.SelectedItem as SecundariaV;
                                    var capobj = pickitemobj.SelectedItem as SecundariaV;
                                    var Totalcap = capobj.CantCap - capbase.CantCap;
                                    calccap.Text = Totalcap.ToString();
                                }
                                else
                                {
                                    DisplayAlert("Atencion", "Porfavor Selecciona datos validos no sea weon", "Aceptar");
                                }
                            }
                        }
                    }
                }
                
            }
            else
            {
                DisplayAlert("Atencion","Porfavor Selecciona datos validos no sea weon","Aceptar");
            }

        }
        private void Listitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemselec = Listitems.SelectedItem as Item;
            if (itemselec != null)
            {
                if (itemselec.Nombreitem == "Hebetate V")
                {
                    pickitembase.SetBinding(Picker.ItemsSourceProperty, new Binding("HebesV"));
                    pickitemobj.SetBinding(Picker.ItemsSourceProperty, new Binding("HebesV"));
                }
                else
                {
                    if (itemselec.Nombreitem == "Armadura Boss V (No hebe)")
                    {
                        pickitembase.SetBinding(Picker.ItemsSourceProperty, new Binding("LivreVs"));
                        pickitemobj.SetBinding(Picker.ItemsSourceProperty, new Binding("LivreVs"));
                    }
                    else
                    {
                        if (itemselec.Nombreitem == "Dandelion V")
                        {
                            pickitembase.SetBinding(Picker.ItemsSourceProperty, new Binding("DandesV"));
                            pickitemobj.SetBinding(Picker.ItemsSourceProperty, new Binding("DandesV"));
                        }
                        else
                        {
                            if (itemselec.Nombreitem == "Arma principal V")
                            {
                                pickitembase.SetBinding(Picker.ItemsSourceProperty, new Binding("PrimariasV"));
                                pickitemobj.SetBinding(Picker.ItemsSourceProperty, new Binding("PrimariasV"));
                            }
                            else
                            {
                                if (itemselec.Nombreitem == "Arma Secundaria V")
                                {
                                    pickitembase.SetBinding(Picker.ItemsSourceProperty, new Binding("SecundariasV"));
                                    pickitemobj.SetBinding(Picker.ItemsSourceProperty, new Binding("SecundariasV"));
                                }
                                else
                                {
                                    pickitembase.ItemsSource = null;
                                    pickitemobj.ItemsSource = null;
                                }
                            }
                        }
                    }
                }
            }  
            else
            {
                pickitembase.ItemsSource = null;
                pickitemobj.ItemsSource = null;
            }
        }

        private void Mostrarlista_Clicked(object sender, EventArgs e)
        {
            var itemselec = Listitems.SelectedItem as Item;
            if(Listitems.SelectedItem != null)
            {
                if (itemselec.Nombreitem == "Hebetate V")
                {
                    ListCapItem.SetBinding(ListView.ItemsSourceProperty, new Binding("HebesV"));
                    ListCapItem.IsVisible = true;
                }
                else
                {
                    Exception ex;
                }
                if (itemselec.Nombreitem == "Armadura Boss V (No hebe)")
                {
                    ListCapItem.SetBinding(ListView.ItemsSourceProperty, new Binding("LivreVs"));
                    ListCapItem.IsVisible = true;
                }
                else
                {
                    Exception ex;
                }
                if (itemselec.Nombreitem == "Dandelion V")
                {
                    ListCapItem.SetBinding(ListView.ItemsSourceProperty, new Binding("DandesV"));
                    ListCapItem.IsVisible = true;
                }
                else
                {
                    Exception ex;
                }
                if (itemselec.Nombreitem == "Arma principal V")
                {
                    ListCapItem.SetBinding(ListView.ItemsSourceProperty, new Binding("PrimariasV"));
                    ListCapItem.IsVisible = true;
                }
                else
                {
                    Exception ex;
                }
                if (itemselec.Nombreitem == "Arma Secundaria V")
                {
                    ListCapItem.SetBinding(ListView.ItemsSourceProperty, new Binding("SecundariasV"));
                    ListCapItem.IsVisible = true;
                }
                else
                {
                    Exception ex;
                }
            }
            else
            {
                DisplayAlert("Advertencia","Selecciona un Item","Aceptar");
            }
          
        }
    }
}