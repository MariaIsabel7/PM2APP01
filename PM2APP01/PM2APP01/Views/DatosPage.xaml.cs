using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2APP01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatosPage : ContentPage
    {
        public DatosPage()
        {
            InitializeComponent();
        }

        private async void btndatos_Clicked(object sender, EventArgs e)
        {
            var personas = new Models.Personas
            {
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                correo = txtcorreo.Text
            };

            var resultPage = new ResultPage();
            resultPage.BindingContext = personas;
            await Navigation.PushAsync(resultPage);

            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text= "";
            txtcorreo.Text = "";

        }

    }
}