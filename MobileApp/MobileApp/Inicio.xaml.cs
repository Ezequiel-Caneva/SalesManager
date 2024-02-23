using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MobileApp.App.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        public Inicio()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
        }
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            var request = new Login
            {
                Username = username,
                Password = password
            };

            HttpResponseMessage response = await _client.PostAsJsonAsync("nombre_del_endpoint_para_iniciar_sesion", request);

            if (response.IsSuccessStatusCode)
            {
                // El inicio de sesión fue exitoso, redirige a la página principal
                var usuario = await response.Content.ReadAsAsync<Usuario>();
                await Navigation.PushAsync(new PaginaPrincipal());
            }
            else
            {
                // El inicio de sesión falló, muestra un mensaje de error al usuario
                await DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
            }
        }
    }
}