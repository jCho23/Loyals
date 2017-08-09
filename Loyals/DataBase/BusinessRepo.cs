using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Loyals
{
	public class BusinessRepo
	{
        private SQLiteConnection sqliteConnection;

        public BusinessRepo(string dbPath)
        {
            sqliteConnection = new SQLiteConnection(dbPath);
            sqliteConnection.CreateTable<LoyaltyCards>();
        }


        static BusinessRepo database;
        public static BusinessRepo Database
        //static = ensures one instance (singleton implementation)
        //Get and/or Set = Property
        //No () = Property
		{
			get
			{
				if (database == null)
				{
                    database = new BusinessRepo(DependencyService.Get<IFileHelper>().GetLocalFilePath("Loyals.db3"));
					//Dependency Service = https://developer.xamarin.com/guides/xamarin-forms/application-fundamentals/dependency-service/
				}
				return database;
			}
		}


		public void AddNewBusiness(string name, string location, string myURL)
		{
            sqliteConnection.Insert(new LoyaltyCards(name, location, myURL ));
		}

		public List<LoyaltyCards> GetAllLoyaltyCards()
		{
			return sqliteConnection.Table<LoyaltyCards>().ToList();
		}

		public LoyaltyCards GetFirstLoyaltyCard()
		{
			return sqliteConnection.Table<LoyaltyCards>().FirstOrDefault();
		}

	}
}



