using System;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using System.ComponentModel;

namespace CarsalesAppAgain.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}
