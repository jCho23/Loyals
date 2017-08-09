using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace Loyals
{
	public interface IFileHelper
	{
		string GetLocalFilePath(string filename);
	}

}
