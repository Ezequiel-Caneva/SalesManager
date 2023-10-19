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
    public partial class FormStock : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        public FormStock()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            List<Rubro> rubros = ObtenerRubros();
            cbRubro.DataSource = rubros;
            cbRubro.DisplayMember = "categoria"; // Nombre de la propiedad que se mostrará en el ComboBox
            cbRubro.ValueMember = "rubroid"; // Nombre de la propiedad que representa el valor seleccionado
            cbBuscarRubro.DataSource = rubros;
            cbBuscarRubro.DisplayMember = "categoria"; // Nombre de la propiedad que se mostrará en el ComboBox
            cbBuscarRubro.ValueMember = "rubroid"; // Nombre de la propiedad que representa el valor seleccionado
        }

        public List<Rubro> ObtenerRubros()
        {
            HttpResponseMessage response = _client.GetAsync($"{_client.BaseAddress}/Stock/ObtenerRubro").Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                var rubros = JsonConvert.DeserializeObject<List<Rubro>>(jsonToDeserialize);

                return rubros;
            }

            return null;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Obtén el rubro seleccionado del ComboBox.
            var rubroSeleccionado = (int)cbRubro.SelectedValue;

            Producto nuevoProducto = new Producto
            {
                nombre = txtNombreProducto.Text,
                codigobarra = txtCodigoProducto.Text,
                precioventa = Convert.ToDecimal(txtPrecioProducto.Text),
                stock = Convert.ToInt32(txtCantidadProducto.Text),
                rubro = rubroSeleccionado // Asigna el rubro seleccionado al producto.
            };
            string data = JsonConvert.SerializeObject(nuevoProducto);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/AgregarProducto", content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Producto agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }

}
