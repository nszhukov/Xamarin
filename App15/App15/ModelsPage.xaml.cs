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
    public partial class ModelsPage : ContentPage
    {
        public ModelsPage()
        {
            InitializeComponent();
        }

        private async void ButtonAclass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AclassPage());
        }

        private async void ButtonBclass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BclassPage());
        }

        private async void ButtonCclass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CclassPage());
        }

        private async void ButtonCla_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClaPage());
        }

        private async void ButtonCls_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClsPage());
        }

        private async void ButtonEclass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EclassPage());
        }

        private async void ButtonEqc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EqcPage());
        }

        private async void ButtonGclass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GclassPage());
        }

        private async void ButtonGla_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlaPage());
        }

        private async void ButtonGlb_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlbPage());
        }

        private async void ButtonGlc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlcPage());
        }

        private async void ButtonGle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlePage());
        }

        private async void ButtonGls_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlsPage());
        }

        private async void ButtonSclass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SclassPage());
        }

        private async void ButtonSl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SlPage());
        }

        private async void ButtonSlc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SlcPage());
        }

        private async void ButtonVclass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VclassPage());
        }

        private async void ButtonEqv_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EqvPage());
        }

        private async void ButtonXclass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XclassPage());
        }

        private async void ButtonAmggt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AmggtPage());
        }

        private async void ButtonMaybach_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaybachPage());
        }
    }
}