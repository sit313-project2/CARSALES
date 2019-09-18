using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace w8
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
           
            InitializeComponent();
        }


        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            var AudiList = new List<string>();
            AudiList.Add("A1");
            AudiList.Add("A3");
            AudiList.Add("A4");
            AudiList.Add("A5");

            var BMWList = new List<string>();
            BMWList.Add("3 series");
            BMWList.Add("4 series");
            BMWList.Add("5 series");
            BMWList.Add("7 series");

            var Fordlist = new List<string>();
            Fordlist.Add("F150");
            Fordlist.Add("Falcon");
            Fordlist.Add("Focus");
            Fordlist.Add("Mustang");

            var HoldenList = new List<string>();
            HoldenList.Add("Astra");
            HoldenList.Add("Colorado");
            HoldenList.Add("Commodore");
            HoldenList.Add("Cruze");

            var HondaList = new List<string>();
            HondaList.Add("Civic");
            HondaList.Add("Accord");
            HondaList.Add("Fit");
            HondaList.Add("NSX");

            var JeepList = new List<string>();
            JeepList.Add("Commander");
            JeepList.Add("Cherokee");
            JeepList.Add("Grand Cherkee");
            JeepList.Add("Wrangler");

            var ToyotaList = new List<string>();
            ToyotaList.Add("86");
            ToyotaList.Add("Camry");
            ToyotaList.Add("Prado");
            ToyotaList.Add("Landcruiser");





            if (selectedIndex != -1)
            {
                monkeyNameLabel.Text = picker.Items[selectedIndex];

                if(picker.Items[selectedIndex]=="Audi")
                picker2.ItemsSource = AudiList;

                if (picker.Items[selectedIndex] == "BMW")
                    picker2.ItemsSource = BMWList;

                if (picker.Items[selectedIndex] == "Ford")
                    picker2.ItemsSource = Fordlist;
                if (picker.Items[selectedIndex] == "Holden")
                    picker2.ItemsSource = HoldenList;
                if (picker.Items[selectedIndex] == "Honda")
                    picker2.ItemsSource = HondaList;
                if (picker.Items[selectedIndex] == "Jeep")
                    picker2.ItemsSource = JeepList;
                if (picker.Items[selectedIndex] == "Toyota")
                    picker2.ItemsSource = ToyotaList;
                

            }
        }

    }
}