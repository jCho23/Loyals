using System;

using Xamarin.Forms;
using Loyals.Pages;
using Loyals.Database;
using Loyals.DataBase;

namespace Loyals
{
	public class App : Application
	{
        public static BusinessRepo BusinessRepo { get; private set; }

		public App()
		{
			string dbPath = FileAccessHelper.GetLocalFilePath("Loyals1.db3");
            BusinessRepo = new BusinessRepo(dbPath);
			// DogRepo.AddNewDog("Olive", "Black");
			// The root page of your application
			MainPage = new NavigationPage(new FirstPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
