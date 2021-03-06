﻿using Xamarin.Forms;

namespace OmkarElectricals.Views
{
    public class LoginPage : ContentPage
    {
        public LoginPage()
        {
            Title = "";
            Label title = new Label
            {
                Text = "Welcome to Omkar Electricals",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            Entry usernameEntry = new Entry
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 400,
                Placeholder = "Enter Username",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry))
            };

            Entry passwordEntry = new Entry
            {
                IsPassword = true,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 400,
                Placeholder = "Enter Password",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry))
            };

            Button loginButton = new Button
            {
                Text = "Login",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 400,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };
            loginButton.Clicked += async (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(usernameEntry.Text))
                {
                    await DisplayAlert("Omkar Electricals", "Please enter username", "OK");
                }
                else if (string.IsNullOrWhiteSpace(passwordEntry.Text))
                {
                    await DisplayAlert("Omkar Electricals", "Please enter password", "OK");
                }
                else if(usernameEntry.Text == "omkar" && passwordEntry.Text == "mitesh")
                {
                    App.Current.MainPage = new NavigationPage(new AddSelectCustomerPage());
                }
                else
                {
                    await DisplayAlert("Omkar Electricals", "Please check username & password", "OK");
                }
            };

            Content = new StackLayout
            {
                Children = { title, usernameEntry, passwordEntry, loginButton },
                Spacing = 10,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}
