using System;
using System.Collections.Generic;
using Loyals.Models;
namespace Loyals.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {
        IList<Business> _listOfBusinesses;

        public IList<Business> ListOfBusinesses
        {
            get { return _listOfBusinesses; }
        }

    }
}
