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







    }
}
