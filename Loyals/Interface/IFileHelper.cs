using System;
using SQLite;
using Xamarin.Forms;

namespace Loyals
{
	public interface IFileHelper
	{
		string GetLocalFilePath(string filename);
	}


	static BusinessRepo database;

	public static BusinessRepo Database
	{
		get
		{
			if (database == null)
			{
                database = new BusinessRepo(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
			}
			return database;
		}
	}


	public BusinessRepo(string dbPath)
	{
		database = new SQLiteAsyncConnection(dbPath);
		database.CreateTableAsync<TodoItem>().Wait();
	}




	public Task<List<TodoItem>> GetItemsAsync()
	{
		return database.Table<TodoItem>().ToListAsync();
	}

	public Task<List<TodoItem>> GetItemsNotDoneAsync()
	{
		return database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
	}

	public Task<TodoItem> GetItemAsync(int id)
	{
		return database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
	}

	public Task<int> SaveItemAsync(TodoItem item)
	{
		if (item.ID != 0)
		{
			return database.UpdateAsync(item);
		}
		else
		{
			return database.InsertAsync(item);
		}
	}

	public Task<int> DeleteItemAsync(TodoItem item)
	{
		return database.DeleteAsync(item);
	}
}
