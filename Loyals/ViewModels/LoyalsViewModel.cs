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

		public void GetPointsData()
		{
			PointsValue = "500";
		}

		private string pointsNeeded;
		public string PointsNeeded;
		//properties ALWAYS has a GET or SET
		{
			get { return pointsNeeded; }
			set
			{
				pointsNeeded = value;


				OnPropertyChanged();
			}
		}

		public void GetNeededData()
		{
			PointsNeeded = "23"     
		}

	}
}
