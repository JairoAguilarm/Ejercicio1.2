using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tarea2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //sobre cargca
        public MainPage(DateTime date)
        {
            InitializeComponent();
        }




        private async void btnmostar_Clicked(object sender, EventArgs e)
        {
           await DisplayAlert(String.Format("Nombre: {0} Apellido: {1} Edad{2} Correo{3} Aviso", txtnombre.Text, txtapellido.Text, txtedad.Text, txtemail.Text),"Aviso","Ok");
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            var empleado = new Models.Empleados
            {
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = txtedad.Text,
                correo = txtemail.Text
            };
          
            //Primer metodo de como llamar el texto en otra pantalla con (Bidingcontext)
            var segunapagina = new Segunapagina();
            segunapagina.BindingContext = empleado;
            await Navigation.PushAsync(segunapagina);
            

            //Segundo metodo de cmo llamar el txto a otra pantalla con (Navigation.push)
            //await Navigation.PushAsync(new Segunapagina(txtnombre.Text, txtapellido.Text, txtedad.Text, txtemail.Text));
            
        }
    }
}
