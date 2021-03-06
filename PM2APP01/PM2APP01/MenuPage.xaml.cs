using PM2APP01.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2APP01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void btnoperaciones_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MainPage());
        }

        private async void btndatos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DatosPage());
        }
    }
}