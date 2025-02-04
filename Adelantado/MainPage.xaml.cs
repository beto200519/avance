namespace Adelantado
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MostrarCamposButton_Clicked(object sender, System.EventArgs e)
        {
            CamposOcultos.IsVisible = true;
        }

        private void AgregarUbicacionButton_Clicked(object sender, System.EventArgs e)
        {
            string direccion = DireccionCompletaEntry.Text;
            string codigoDispenser = CodigoDispenserEntry.Text;
            string idTecnico = IdTecnicoEntry.Text;
            string idSupervisor = IdSupervisorEntry.Text;

            DisplayAlert("Éxito", "Ubicación agregada correctamente", "OK");

            CamposOcultos.IsVisible = false;
        }

        private void CancelarButton_Clicked(object sender, System.EventArgs e)
        {
            CamposOcultos.IsVisible = false;
        }
    }
}