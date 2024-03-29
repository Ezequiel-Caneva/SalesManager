﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
using App.Entities;
using Newtonsoft.Json;

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
            var request = new LoginRequest
            {
                usuario = username,
                contrasenia = password
            };
            string data = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Usuario/Login", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonToDeserialize = await response.Content.ReadAsStringAsync();
                var usuarioLogeado = JsonConvert.DeserializeObject<Usuario>(jsonToDeserialize);
                if (usuarioLogeado != null)
                {
                    await Navigation.PushAsync(new Menu(usuarioLogeado));
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
    }
}