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

            btnLogin.Clicked += BtnLoginClicked;
            btnCreateAccount.Clicked += BtnCreateAccountClicked;
        }

        void BtnLoginClicked (object sender, EventArgs e)
        {
            if (accountManager.LoginToAccount(entryUserName.Text, entryPassword.Text) == false)
            {
                DisplayAlert("Login Failed",
                            "Unable to login, please check your username and password",
                            "OK");
            }
        }





    }
}
