using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarSales
{
    public partial class LoginPage : ContentPage
    {
        [Obsolete]
        public LoginPage()
        {
            InitializeComponent();
            this.BackgroundImage = "wallpaper.png";
        }
        public async void SubmitCommand_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CarSalesListPage());


            Application.Current.MainPage = new CarSalesListPage();

            BindingContext = this;
            await DisplayAlert("Alert", "Request Succes.", "OK");
        }

    }
}
