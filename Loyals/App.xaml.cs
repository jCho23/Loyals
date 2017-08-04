using Loyals.DataBase;
using Loyals.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Loyals
{
    public partial class App : Application
    {
        public static BusinessRepo BusinessRepo { get; private set; }

        public App()
        {
            InitializeComponent();
            string dbPath = FileAccessHelper.GetLocalFilePath("Loyals1.db3");
            BusinessRepo = new BusinessRepo(dbPath);
            // DogRepo.AddNewDog("Olive", "Black");
            // The root page of your application
            MainPage = new NavigationPage(new FirstPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
