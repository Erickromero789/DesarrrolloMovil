using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovilApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cbox_terminos_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbox_terminos.IsChecked)
                btn_register.IsEnabled = true;
            else
                btn_register.IsEnabled = false;
        }
        private void btn_register_Clicked(object sender, EventArgs e)
        {
            if (lbl_password == lbl_password1)
            {
                limpiarregistros();
                DisplayAlert("¡Registro Exitoso!, gracias, Continuar");
            }
            else
            {
                DisplayAlert("verifique Su Contraseña, Deben Ser Iguales, modificar");
                lbl_password.Text = "";
                lbl_password1.Text = "";
            }
        }

        private string DisplayAlert(string v)
        {
            return v;
        }

        private void limpiarregistros()
        {
           lbl_nombre.Text="";
           lbl_correo.Text = "";
           lbl_password.Text = "";
           lbl_password1.Text = "";
           progress.ProgressTo(0,250,Easing.Linear);
        }

        private void sw_example_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Hola,Gracias Por Utilizar Este Formulario, Exit");
        }
        private void lbl_nombre_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.25, 250, Easing.Linear);
            lbl_progress.Text = "25%";
        }
        private void lbl_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nombre = lbl_nombre.Text.ToString();
            string cadena = $"Bienvenido {nombre} Ingrese Sus Datos";
            lbl_principal.Text = cadena; 
        }
        private void lbl_correo_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.50, 250, Easing.Linear);
            lbl_progress.Text = "50%";
        }
        private void lbl_password_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.75, 250, Easing.Linear);
            lbl_progress.Text = "75%";
        }
        private void lbl_password1_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.100, 250, Easing.Linear);
            lbl_progress.Text = "100%";
        }
    }
}
