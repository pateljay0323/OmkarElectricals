﻿using OmkarElectricals.DataAccess;
using Xamarin.Forms;

namespace OmkarElectricals.Views
{
    public class InitializationPage : ContentPage
    {
        public InitializationPage()
        {
            Title = "";
            Content = new ActivityIndicator
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                IsRunning = true,
                IsVisible = true
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var a = 5;
            var b = 0;
            var c = a / b;
            await new DatabaseInitialization().InitializeTablesAsync();
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}
