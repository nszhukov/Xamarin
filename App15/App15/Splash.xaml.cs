using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;

namespace App15
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Splash : ContentPage
	{
		public Splash ()
		{
			InitializeComponent ();
		}
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3800);
            Application.Current.MainPage = new MainPage();
        }
    }
}