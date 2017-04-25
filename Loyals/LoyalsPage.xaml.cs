using Xamarin.Forms;

namespace Loyals
{
	public partial class LoyalsPage : ContentPage
	{
		public LoyalsPage(RewardsStore storeToBind)
		{
			InitializeComponent();

			//Create ViewModel and pass "storeToBind" into ViewModel
			//Bind ViewModel to Page using BindingContext Property on LoyalsPage

		}
	}
}
