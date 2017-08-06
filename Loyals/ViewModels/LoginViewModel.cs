using System;
using System.ComponentModel;
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
        }



    }
}
