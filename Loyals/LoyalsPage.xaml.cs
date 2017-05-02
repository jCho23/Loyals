using Xamarin.Forms;

namespace Loyals
{
	public partial class LoyalsPage : ContentPage
	{
		public LoyalsPage()
		{
			InitializeComponent();

			//Create ViewModel and pass "storeToBind" into ViewModel
			//Bind ViewModel to Page using BindingContext Property on LoyalsPage
			viewModel = new LoyalsViewModel();
			BindingContext = viewModel;

		}

private LoyalsViewModel viewModel;


		protected override void OnAppearing()
		{
			base.OnAppearing();

			viewModel.GetData();
		}


	}
}
