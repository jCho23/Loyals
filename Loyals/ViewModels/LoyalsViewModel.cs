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

		public void GetData()
		{
			PointsValue = "500";
			PointsNeeded = "23";
			BusinessName = "Zing Cafe";
		}

		private string pointsNeeded;
		public string PointsNeeded
		//properties ALWAYS has a GET or SET
		{
			get { return pointsNeeded; }
			set
			{
				pointsNeeded = value;


				OnPropertyChanged();
			}
		}

		private string BusinessName;
		public string businessName
		//properties ALWAYS has a GET or SET
		{
			get { return businessName; }
			set
			{
				businessName = value;


				OnPropertyChanged();
			}
		}

	}
}
