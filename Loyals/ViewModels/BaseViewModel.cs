using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Loyals
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] //This is an Attribute, always in Square Brackets
		                                         string propertyName=null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}attribute
		}
	}
}