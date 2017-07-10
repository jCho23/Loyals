using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Loyals.Models;
using System.Diagnostics;

namespace Loyals.Pages
{
    public class FirstPage : ContentPage
    {

        public FirstPage()
        {
            Label header = new Label()
            {
                Text = "ListView",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };


            List<Business> businesses = new List<Business>()
            {
                new Business("Zing Cafe", new DateTime(2017, 5, 15)),

                new Business("La Petite Hair Salon", new DateTime(2017, 5, 16))
            };


            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = businesses,
                //ItemTemplate need to set to data template of view cell
            };

            Button checkPointsButton = new Button { Text = "Check Points" };

            //When you are in the the constructor, you have an instance of that class (first page)

            var newLayoutInstance = new StackLayout();
            newLayoutInstance.Children.Add(header);
            newLayoutInstance.Children.Add(listView);
            newLayoutInstance.Children.Add(checkPointsButton);

            Content = new StackLayout()
            {
                Children =
                {
                    header,
                    listView,
                    checkPointsButton
                }
            };
        }

        public class BusinessViewCell : ViewCell
        {
            public BusinessViewCell()
            {
				var myTextProperty = new Label() { Text = "Text" };
				var myDetailProperty = new Label() { Text = "Details" };

                var textStack = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Orientation = StackOrientation.Vertical,
                    Children =
                    {
                        myTextProperty,
                        myDetailProperty
                    }
                };

                var cellLayoutStack = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        textStack
                    }
                };

                View = textStack;

                var moreAction = new MenuItem { Text = "More" };
                moreAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
                moreAction.Clicked += async (sender, e) =>
                {
                    var mi = ((MenuItem)sender);
                    Debug.WriteLine("More Context Action Clicked: " + mi.CommandParameter);
                };

                var deleteAction = new MenuItem { Text = "Delete", IsDestructive = true }; //red background
                deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
                deleteAction.Clicked += async (sender, e) =>
                {
                    var mi = ((MenuItem)sender);
                    Debug.WriteLine("Delete Context Action clicked: " + mi.CommandParameter);
                };
                //Add to Viewcell's ContextActions property
                ContextActions.Add(moreAction);
                ContextActions.Add(deleteAction);
            }
        }
	}
}
