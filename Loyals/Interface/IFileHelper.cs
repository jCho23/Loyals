﻿using System;
using SQLite;
using Xamarin.Forms;

namespace Loyals
{
	public interface IFileHelper
	{
		string GetLocalFilePath(string filename);
	}



	static TodoItemDatabase database;

	public static TodoItemDatabase Database
	{
		get
		{
			if (database == null)
			{
				database = new TodoItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
			}
			return database;
		}
	}


	public TodoItemDatabase(string dbPath)
	{
		database = new SQLiteAsyncConnection(dbPath);
		database.CreateTableAsync<TodoItem>().Wait();
	}

}
