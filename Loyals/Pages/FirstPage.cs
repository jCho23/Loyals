using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Loyals.Pages
{
    public class FirstPage
    {
		class BusinessName
		{
			public BusinessName(string name, DateTime lastVisit )
			{
				this.Name = name;
				this.LastVisit = lastVisit;
			}

			public string Name { private set; get; }

			public DateTime LastVisit { private set; get; }

			public Color FavoriteColor { private set; get; }
		};

	}
}
