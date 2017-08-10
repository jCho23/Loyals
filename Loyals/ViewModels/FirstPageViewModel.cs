using System;
using System.Collections.Generic;
using Loyals.Models;
namespace Loyals.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {
        IList<FaveItem> _listOfBusinesses;

        public IList<FaveItem> ListOfBusinesses
        {
            get { return _listOfBusinesses; }
            set { SetProperty (ref _listOfBusinesses, value); }
        }

    }
}
