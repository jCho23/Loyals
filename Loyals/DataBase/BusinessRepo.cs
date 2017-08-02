using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Loyals.Models;
using Loyals.DataBase;

namespace Loyals.DataBase
{
	public class BusinessRepo
	{
        private SQLiteConnection sqliteConnection;

        public BusinessRepo(string dbPath)
        {
            sqliteConnection = new SQLiteConnection(dbPath);
            sqliteConnection.CreateTable<LoyaltyCards>();
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



