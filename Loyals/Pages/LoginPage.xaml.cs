using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace Loyals
{
    public partial class LoginPage : ContentPage
    {
        public event Action<Account> LoginSucceeded = (x) => { };
        AccountManager accountManager;

        public LoginPage()
        {
            InitializeComponent();

            accountManager = new AccountManager();

            btnLogin.Clicked += BtnLogin_Clicked;
            btnCreateAccount.Clicked += BtnCreateAccount_Clicked;
            btnFPLogin.Clicked += BtnFPLogin_Clicked;
        }

        void BtnFPLogin_Clicked(object sender, EventArgs e)
        {

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
            
        }


    }
}
