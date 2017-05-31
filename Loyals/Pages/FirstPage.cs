using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Loyals.Models;

namespace Loyals.Pages
{
    public class FirstPage : ContentPage
    {

        public FirstPage()
        {
            Label header = new Label
            {
                Text = "ListView",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };


            List<Business> businesses = new List<Business>
            {
                new Business("Zing Cafe", new DateTime(2017, 5, 15)),

                new Business("La Petite Hair Salon", new DateTime(2017, 5, 16))
            };


            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = businesses,

            };
        }
	}
}
