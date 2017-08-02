using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Loyals.Models;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace Loyals.Pages
{
    public class FirstPage : ContentPage
    {
        //Observable collections automatically Update the UI; however, listviews don't 
        public static ObservableCollection<Business> businesses = new ObservableCollection<Business>()
			{
				new Business("Zing Cafe", new DateTime(2017, 5, 15)),

				new Business("La Petite Hair Salon", new DateTime(2017, 5, 16))
			};

        public FirstPage()
        {
            Label header = new Label()
            {
                Text = "ListView",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = businesses,
                ItemTemplate = new DataTemplate(typeof(BusinessViewCell))
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
				//red background
				var deleteAction = new MenuItem { Text = "Delete", IsDestructive = true }; 
                deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
                deleteAction.Clicked += (sender, e) =>
                {
					//This is Called Type-Casting
					var mi = ((MenuItem)sender);
                    Debug.WriteLine("Delete Context Action clicked: " + mi.CommandParameter);
                    //This is the second Type of type-Casting
                    var item = mi.CommandParameter as Business;
                    FirstPage.businesses.Remove(item);
                };
                //Add to Viewcell's ContextActions property
                ContextActions.Add(moreAction);
                ContextActions.Add(deleteAction);
            }
        }


		//public class CustomCell : Cellx
		//{
		//	public CustomCell()
		//	{
		//		//instantiate each of our views
		//		var image = new Image();
		//		StackLayout cellWrapper = new StackLayout();
		//		StackLayout horizontalLayout = new StackLayout();
		//		Label left = new Label();
		//		Label right = new Label();

		//		//set bindings
		//		left.SetBinding(Label.TextProperty, "title");
		//		right.SetBinding(Label.TextProperty, "subtitle");
		//		image.SetBinding(Image.SourceProperty, "image");

		//		//Set properties for desired design
		//		cellWrapper.BackgroundColor = Color.FromHex("#eee");
		//		horizontalLayout.Orientation = StackOrientation.Horizontal;
		//		right.HorizontalOptions = LayoutOptions.EndAndExpand;
		//		left.TextColor = Color.FromHex("#f35e20");
		//		right.TextColor = Color.FromHex("503026");

		//		//add views to the view hierarchy
		//		horizontalLayout.Children.Add(image);
		//		horizontalLayout.Children.Add(left);
		//		horizontalLayout.Children.Add(right);
		//		cellWrapper.Children.Add(horizontalLayout);
		//		View = cellWrapper;
		//	}
		//}








	}
}
