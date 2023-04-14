using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgramMov2023
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eventos : ContentPage
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            string nombre ,apellido;

            nombre = etnombre.Text;
            apellido = etapellido.Text;
            
            if (string.IsNullOrEmpty(nombre))
            {

                DisplayAlert("Titulo","Eventos", "Aceptar");
                etnombre.Text = "Hola ";
            }


        }

        private void etapellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            etnombre.Text = etapellido.Text.Length.ToString();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            DisplayAlert("Eventos", "Eventos check", "OK");
        }
    }
}