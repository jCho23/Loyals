using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Loyals.Pages
{
    public class FirstPage
    {
		class BusinessName
		{
			public BusinessName(string name, DateTime lastVisit)
			{
				this.Name = name;
				this.LastVisit = lastVisit;
			}

			public string Name { private set; get; }

			public DateTime LastVisit { private set; get; }

			public Color FavoriteColor { private set; get; }
		};


        public Businesses()
        {
            Label header = new Label
            {
                Text = "ListView",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
        }

        List<BusinessName> businessName = new List<BusinessName>
			{
            new BusinessName("Zing Cafe", new DateTime(2017, 5, 15), Color.Aqua),
		
            new BusinessName("La Petite Hair Salon", new DateTime(2017, 5, 16), Color.Purple)
				
			};


        ListView listView = new ListView
        {
            // Source of data items.
            ItemsSource = businessName,

        };

	}
}
