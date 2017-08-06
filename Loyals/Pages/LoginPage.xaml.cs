using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Plugin.Fingerprint;

namespace Loyals
{
    public partial class LoginPage : ContentPage
    {
        public event Action<Account> LoginSucceeded = (j) => { };
        AccountManager accountManager;

        public LoginPage()
        {
            InitializeComponent();

            accountManager = new AccountManager();

            btnLogin.Clicked += BtnLogin_Clicked;
            btnCreateAccount.Clicked += BtnCreateAccount_Clicked;
            btnFPLogin.Clicked += BtnFPLogin_Clicked;
        }

        private void BtnFPLogin_Clicked(object sender, EventArgs e)
        {
            var result = await CrossFingerprint.Current.IsAvailableAsync(true);
            if (result)
            {
                var auth = await CrossFingerprint.Current.AuthenticateAsync("Authenticate Access to your Rewards");
                if (auth.Authenticated)
                {
                    var username = "fpAuth";
                    LoginSucceeded(accountManager.GetAccount(username));
                }
                else
                {
                    await DisplayAlert("Authentication Failed", 
                                       "FingerPrint Authentication Failed", 
                                       "OK");   
                }
            }
        }

        void BtnLogin_Clicked (object sender, EventArgs e)
        {
            if (accountManager.LoginToAccount(entryUserName.Text, entryPassword.Text) == false)
            {
                DisplayAlert("Login Failed",
                            "Unable to login, please check your username and password",
                            "OK");
            }

            else
            {
                LoginSucceeded(accountManager.GetAccount(entryUserName.Text));
                entryPassword.Text = string.Empty;
                entryUserName.Text = string.Empty;
            }
        }

        void BtnCreateAccount_Clicked (object sender, EventArgs e)
        {
            if (accountManager.CreateAndSaveAccount(entryUserName.Text, entryPassword.Text) == true)
                LoginSucceeded(accountManager.GetAccount(entryUserName.Text));
            else
                DisplayAlert("Create Account Failed",
                             "Unable to create a new account - does this account already exist?",
                             "OK");
        }
    }
}
