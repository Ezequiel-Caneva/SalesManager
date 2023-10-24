using App.Entities;
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
    public partial class subEnvios : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private Envio _envio;
        public subEnvios(Envio envio)
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _envio = envio;
        }

        private void subEnvios_Load(object sender, EventArgs e)
        {
            txtFechaEn.Text = DateTime.Now.ToString();
            label5.Text = $"Pedido N°:{_envio.pedido}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            _envio.empresa_transporte = cbEmpresa.Text;
            _envio.fecha_envio = DateTime.Parse(txtFechaEn.Text);
            _envio.fecha_recepcion = DateTime.Parse(txtFechaRecep.Text);
            _envio.codigoseguimiento = Convert.ToInt32(txtCodigoSeguimiento.Text);
            string data = JsonConvert.SerializeObject(_envio);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/EnvioNuevo", content).Result;
            if (response.IsSuccessStatusCode)
            {
                bool envio = JsonConvert.DeserializeObject<bool>(response.Content.ReadAsStringAsync().Result);
                if (envio == true)
                {

                    MessageBox.Show("Envio cargado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar el envio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el envio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
