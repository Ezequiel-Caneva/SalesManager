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
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        public Login()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContrasenia.Text))
            {
                //var passwordHasher = new PasswordHasher<string>();
                //string hashedPassword = passwordHasher.HashPassword(null!, txtPassword.Text);

                var loginRequest = new LoginRequest()
                {
                    usuario = txtUsuario.Text,
                    contrasenia = txtContrasenia.Text
                    //PasswordHash = hashedPassword,
                };

                string data = JsonConvert.SerializeObject(loginRequest); // serializa el user 
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");  // pasa el lo serializado a la api web
                HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Usuario/Login", content).Result; // llamada a la api
                if (response.IsSuccessStatusCode && response.Content.ReadAsStringAsync().Result.Equals("true"))  // si es correcto el logeo 
                {
                    var form = new Inicio();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email and Password don't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please fill all required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
