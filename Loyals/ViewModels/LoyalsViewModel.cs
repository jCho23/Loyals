using System;
namespace Loyals
{
	public class LoyalsViewModel : BaseViewModel
	{
		public LoyalsViewModel()
		{
		}

		private string pointsValue;
		public string PointsValue
		//properties ALWAYS has a GET or SET
		{
			get { return pointsValue; }
			set
			{
				pointsValue = value;


				OnPropertyChanged();
			}
		}



	}
}
