using System;
using Xamarin.Forms;
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

		private string pointsNeeded;
		public string PointsNeeded
		{
			get { return pointsNeeded; }
			set
			{
				pointsNeeded = value;


                OnPropertyChanged();
				OnPropertyChanged("PointsNeededColor");
				//If you don't pass the property name, the default is the CallerMemberName 
				//Example: (see in BaseViewModel)
			}
		}

		private string businessName;
		public string BusinessName
		{
			get { return businessName; }
			set
			{
				businessName = value;


				OnPropertyChanged();
			}
		}

		private string businessType;
		public string BusinessType
		{
			get { return businessType; }
			set
			{
				businessType = value;


				OnPropertyChanged();
			}
		}

		private ImageSource profilePicture;
		public ImageSource ProfilePicture
		{
			get { return profilePicture; }
			set
			{
				profilePicture = value;

				OnPropertyChanged();
			}

		}

		public Color PointsNeededColor
		{
			get {

				if (string.IsNullOrEmpty(PointsNeeded))
					return Color.Green;

				var pointsValue = Convert.ToDouble(PointsNeeded);

				if (pointsValue > 50)
					return Color.Green;
				else
					return Color.Red;
			}
		}

		public void GetData()
		{
			PointsValue = "330";
			PointsNeeded = "23";
			BusinessName = "Zing Cafe";
			BusinessType = "Sandwich Shop";
			ProfilePicture = "ZingProfile.jpg";
		}

		public void UpdateDate(object sender, EventArgs e)
		{
			PointsValue = "111";
			PointsNeeded = "222";
			BusinessName = "Different place";
			BusinessType = "Barber Shop";
		}
	}
}
