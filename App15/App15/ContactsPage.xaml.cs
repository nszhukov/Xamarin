using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App15
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{

        internal class Contacts
        {
            public string City { get; set; }
            public string Phone { get; set; }
        }

        IEnumerable<Contacts> GetContacts(string searchText = null)
        {

            var contacts = new List<Contacts>
            {
                new Contacts { City = "Minsk (Auto House Energy GmbH)", Phone = "8(017)309-99-99"},
                new Contacts { City = "Moscow (Avilon)", Phone = "+7(495)153-75-36"},
                new Contacts { City = "Moscow (Avilon Vozdvizhenka),", Phone = "+7(495)781-77-07"},
                new Contacts { City = "Moscow (MB Belyaevo)", Phone = "+7(495)788-10-10"},
                new Contacts { City = "Moscow (Mercedes-Benz RUS)", Phone = "+7(495)225-00-00"},
                new Contacts { City = "Saint-Petersburg (AVTODOM Pulkovo)", Phone = "+7(812)500-50-05"},
                new Contacts { City = "Saint-Petersburg (AVANGARD)", Phone = "+7(812)561-15-40"},
                new Contacts { City = "Saint-Petersburg (Vagner)", Phone = "+7(812)602-39-77"},
                new Contacts { City = "Warszawa (Auto Idea Sp. z o.o.)", Phone = "+48 22 312-70-00"},
                new Contacts { City = "Kiev (Avtomobil'nyy Dim Ukraine - MB)", Phone = "+380(44)277-26-43"},
                new Contacts { City = "Kiev (Official dealer)", Phone = "+380(44)503-69-49"},
            };

            if (string.IsNullOrEmpty(searchText))
                return contacts;
            return contacts.Where(p => p.City.ToLower().StartsWith(searchText));
        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
        }

        public ContactsPage ()
		{
			InitializeComponent ();
            listView.ItemsSource = GetContacts();
            this.BindingContext = this;
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue.ToLower());
        }
    }
}