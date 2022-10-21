using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2_P1Tarea1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnMostrar_Clicked(object sender, EventArgs e)
        {
            
                var datosAgenda = new Models.DatosAgenda
                {

                    id = 1,
                    nombre = txtnombre.Text,
                    apellido = txtapellido.Text,
                    edad = txtedad.Text,
                    correo = txtcorreo.Text
                };

                var pagemostrar = new Views.PageMostrar();
                pagemostrar.BindingContext = datosAgenda;
                await Navigation.PushAsync(pagemostrar);
          
        }

        private void btnBorrar_Clicked(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txtcorreo.Text = "";

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
