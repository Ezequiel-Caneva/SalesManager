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
    public partial class subpromocion : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        int _productoid;
        public subpromocion(int productoid)
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _productoid = productoid;
        }

        private void subpromocion_Load(object sender, EventArgs e)
        {
            var search = new Search()
            {
                num = _productoid,
                TextToSearch = "",
                PageIndex = 0,
                PageSize = 0,
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/TraerProducto", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Producto>(jsonToDeserialize);
            lbProducto.Text = "Producto: " + result.nombre;
            lblPrecio.Text = "Precio: " + result.precioventa.ToString();

        }

        private void btnPromocionar_Click(object sender, EventArgs e)
        {

            var search = new Search()
            {
                num = _productoid,
                TextToSearch = txtDescuento.Text,
                PageIndex = 0,
                PageSize = 0,
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/Descontar", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Boolean>(jsonToDeserialize);
            if (response.IsSuccessStatusCode && result == true)
            {

                MessageBox.Show("Descuento Agregado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo agregar descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
