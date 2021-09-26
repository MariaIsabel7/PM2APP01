using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2APP01
{
    public partial class MainPage : ContentPage

    {
        public MainPage()
        {
      
            InitializeComponent();
           
        }

        decimal suma, resta, mult, div, num1, num2;

        private async void btnsuma_Clicked (object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtnum1.Text);
            num2 = Convert.ToDecimal(txtnum2.Text);
            suma = num1 + num2;

            var operaciones = new Models.Operaciones
            {
                resultado = suma
            };

            var secondPage = new SecondPage();
            secondPage.BindingContext = operaciones;
            await Navigation.PushAsync(secondPage);

     


        }

    

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtnum1.Text);
            num2 = Convert.ToDecimal(txtnum2.Text);
            resta = num1 - num2;
            var operaciones = new Models.Operaciones
            {
                resultado = resta
            };

            var secondPage = new SecondPage();
            secondPage.BindingContext = operaciones;
            await Navigation.PushAsync(secondPage);

        }

        private async void btnmult_Clicked(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtnum1.Text);
            num2 = Convert.ToDecimal(txtnum2.Text);
            mult = num1 * num2;
            var operaciones = new Models.Operaciones
            {
                resultado = mult
            };

            var secondPage = new SecondPage();
            secondPage.BindingContext = operaciones;
            await Navigation.PushAsync(secondPage);

        }

        private async void btndiv_Clicked(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtnum1.Text);
            num2 = Convert.ToDecimal(txtnum2.Text);
            div = num1 / num2;
            var operaciones = new Models.Operaciones
            {
                resultado = div
            };

            var secondPage = new SecondPage();
            secondPage.BindingContext = operaciones;
            await Navigation.PushAsync(secondPage);

        }

        

    }
}
