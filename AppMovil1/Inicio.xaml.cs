using Newtonsoft.Json;
using System.Text;
using App.Entities;

namespace AppMovil1;

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
        try
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;
            var request = new LoginRequest
            {
                usuario = username,
                contrasenia = password
            };
            string data = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync($"{_client.BaseAddress}/Usuario/Login", content);
            if (response.IsSuccessStatusCode)
            {
                var jsonToDeserialize = await response.Content.ReadAsStringAsync();
                var usuarioLogeado = JsonConvert.DeserializeObject<Usuario>(jsonToDeserialize);
                if (usuarioLogeado != null)
                {
                    await Navigation.PushAsync(new Menu());
                }
                else
                {
                    await DisplayAlert("Error", "El usuario obtenido es nulo", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Inicio de sesión fallido", "OK");
            }
        }
        catch (Exception ex)
        {
            // Manejar excepciones aquí
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
