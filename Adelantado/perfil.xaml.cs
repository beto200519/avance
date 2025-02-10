using Microsoft.Maui.Controls;

namespace Adelantado
{
    public partial class Perfil: ContentPage
    {
        public Perfil(string username)
        {
            InitializeComponent();

            // Asigna los valores a los labels
            lblName.Text = username;
            lblEmail.Text = "hello@reallygreatsite.com";
            lblPhone.Text = "+52 65454661";
            lblMatricula.Text = "45661564984204681854";
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}