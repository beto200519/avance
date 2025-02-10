using Microsoft.Maui.Controls;
using System;

namespace Adelantado
{
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Por favor ingrese un usuario y una contrase�a", "OK");
                return;
            }

            // Simulaci�n de autenticaci�n
            if (username == "Jiara Martins" && password == "1234")
            {
                await Navigation.PushAsync(new Perfil(username));
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
            }
        }
    }
}