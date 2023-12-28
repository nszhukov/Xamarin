using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App15
{
    public partial class MainPage : MasterDetailPage
    {
        protected internal static string lang = "eng";
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new TitulPage())
            {
                BarBackgroundColor = Color.Black
            };
        }

        private void MenuModels_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ModelsPage())
            {
                BarBackgroundColor = Color.Black
            };
            IsPresented = false;
        }

        private void MenuAbout_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new FriendsListPage())
            {
                BarBackgroundColor = Color.Black
            };
            IsPresented = false;
        }

        private void MenuTitul_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TitulPage())
            {
                BarBackgroundColor = Color.Black
            };
            IsPresented = false;
        }

        private void MenuContact_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ContactsPage())
            {
                BarBackgroundColor = Color.Black
            };
            IsPresented = false;
        }

        internal async void MenuLanguage_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("", "Cancel", "", "English", "Русский");
    
            //____________________________________________
            if(Convert.ToString(action) == "English")
            {
                lang = "eng";
                menuModels.Text = "Vehicles";
                menuAbout.Text = "Reviews";
                menuContact.Text = "Contacts";
                menuLanguage.Text = "Language";
                menuTitul.Text = "Main";
            }
            if (Convert.ToString(action) == "Русский")
            {
                lang = "rus";
                menuModels.Text = "Автомобили";
                menuAbout.Text = "Отзывы";
                menuContact.Text = "Контакты";
                menuLanguage.Text = "Язык";
                menuTitul.Text = "Главная";      
            }
            //____________________________________________
        }
    }
}
