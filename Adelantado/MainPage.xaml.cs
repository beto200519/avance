using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Adelantado
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Historial { get; set; }
        public ICommand AbrirPuertaCommand { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            // Inicializa la lista de historial
            Historial = new ObservableCollection<string>();

            // Inicializa el comando ANTES de asignar el BindingContext
            AbrirPuertaCommand = new Command(AgregarHistorial);

            // Establece el BindingContext correctamente
            BindingContext = this;
        }

        private void AgregarHistorial()
        {
            string timestamp = $"Acceso registrado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            Historial.Add(timestamp);
        }

        private async void OnImageTapped(object sender, EventArgs e)
        {
            var image = (Image)sender;

            // Efecto de pulsación
            await image.ScaleTo(0.7, 100);
            await image.ScaleTo(1, 100);
            // Agregar solo una vez al historial
            AgregarHistorial();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            btnImagen.Opacity = 0;  // Inicia invisible
            await btnImagen.FadeTo(1, 1000);  // Se desvanece en 1 segundo
        }
    }
}