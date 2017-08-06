using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
namespace Loyals
{
    public class LoginViewModel : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler PropertyChanged = delegate {};

        public Action DisplayInvalidLoginPrompt;

        public string emailAddress;
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EmailAddress"));
            }
        }

        public string password;
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }

        }

        public ICommand SubmitCommand { protected set; get; }

        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            if (emailAddress != "June@june.com" || password != "june")
                DisplayInvalidLoginPrompt();
        }
    }
}
