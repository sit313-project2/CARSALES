using System;
using System.Collections.Generic;
using CarsalesAppAgain.Views;
using Xamarin.Forms;

namespace CarsalesAppAgain
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            this.BackgroundImage = "wallpaper.png";
        }

        public async void SubmitCommand_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CarSalesListPage());


            Application.Current.MainPage = new MainPage();


            BindingContext = this;
            await DisplayAlert("Alert", "Request Succes.", "OK");
        }


    }
}