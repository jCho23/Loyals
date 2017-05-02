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
		//properties ALWAYS has a GET or SET
		{
			get { return pointsNeeded; }
			set
			{
				pointsNeeded = value;


				OnPropertyChanged();
			}
		}

		private string businessName;
		public string BusinessName
		//properties ALWAYS has a GET or SET
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
		//properties ALWAYS has a GET or SET
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

		private Color pointsNeededColor;
		public Color PointsNeededColor
		{
			get { return pointsNeededColor; }
			set
			{
				pointsNeededColor = value;

				OnPropertyChanged();
			}
		}



		public void GetData()
		{
			PointsValue = "330";
			PointsNeeded = "23";
			BusinessName = "Zing Cafe";
			BusinessType = "Sandwich Shop";
			PointsNeededColor = Color.Red;
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
