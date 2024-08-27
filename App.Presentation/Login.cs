using App.Entities;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation
{
    public partial class Login : Form
    {
        private readonly Uri _baseAddress = new Uri("http://mototopAPI.somee.com/api");
        private readonly HttpClient _client;
        private static Usuario _usuarioLogeado;
        public Login()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _usuarioLogeado = new Usuario();
            txtUsuario.Text = "ezequiel";
            txtContrasenia.Text = "123456";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContrasenia.Text))
            {
                var loginRequest = new LoginRequest()
                {
                    usuario = txtUsuario.Text,
                    contrasenia = txtContrasenia.Text
                };
                string data = JsonConvert.SerializeObject(loginRequest);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Usuario/Login", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                    var usuarioLogeado = JsonConvert.DeserializeObject<Usuario>(jsonToDeserialize);

                    if (usuarioLogeado != null) // Verifica si el objeto de usuario no es nulo
                    {
                        _usuarioLogeado = usuarioLogeado;
                        Inicio form = new Inicio(_usuarioLogeado);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email and Password don't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Error during login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
