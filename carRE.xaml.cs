using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace w8
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
            public MainPage()
        {
            var ModelNameLabel = new Label();
            ModelNameLabel.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker1));
            
            string a;
            a = ModelNameLabel.Text;
            int i = 0;
            if(a=="Audi") i = 1;
            if (a == "BMW") i = 2;
            if (a == "Ford") i = 3;
            if (a == "Holden") i = 4;
            if (a == "Honda") i = 5;
            if (a == "Jeep") i = 6;
            if (a == "Toyata") i = 7;
            
                    var modelList = new List<string>();
                    modelList.Add("A4");
                    modelList.Add("A5");
                    modelList.Add("A6");
                    var picker2 = new Picker();
                    picker2.ItemsSource = modelList;
                   
            
           
            InitializeComponent();
        }
    }
}
