using System;
using System.Collections.Generic;
using CarsalesAppAgain.Views;
// using CarsalesAppAgain.Core.Services;
using System.ComponentModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace CarsalesAppAgain
{
    public partial class Login : ContentPage
    {
        private string _username;
        private string _password;
        private bool _areCredentialsInvalid;

        public Login()
        {

            InitializeComponent();
            this.BackgroundImage = "wallpaper.png";
        }

        //public Login(INavigationService navigationService)
        //{
        //    AuthenticateCommand = new Command(() =>
        //    {
        //        AreCredentialsInvalid = !UserAuthenticated(Username, Password);
        //        if (AreCredentialsInvalid) return;

        //        navigationService.GoBack();
        //    });

        //    AreCredentialsInvalid = false;
        //}

        //private bool UserAuthenticated(string username, string password)
        //{
        //    if (string.IsNullOrEmpty(username)
        //        || string.IsNullOrEmpty(password))
        //    {
        //        return false;
        //    }

        //    return username.ToLowerInvariant() == "joe"
        //        && password.ToLowerInvariant() == "secret";
        //}


        public string Username
        {
            get => _username;
            set
            {
                if (value == _username) return;
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value == _password) return;
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand AuthenticateCommand { get; set; }

        public bool AreCredentialsInvalid
        {
            get => _areCredentialsInvalid;
            set
            {
                if (value == _areCredentialsInvalid) return;
                _areCredentialsInvalid = value;
                OnPropertyChanged(nameof(AreCredentialsInvalid));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public async void SubmitCommand_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarSalesListPage());

            //return username.ToLowerInvariant() == "joe"
            //    && password.ToLowerInvariant() == "secret";



            Application.Current.MainPage = new MainPage();


            BindingContext = this;
            await DisplayAlert("Alert", "Request Succes.", "OK");
        }


    }
}