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
    public partial class FormClientes : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        public int _clienteid;
        public FormClientes()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentItemsPerPage = 25;
            _currentPage = 1;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            MostrarCliente("");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente clienteNuevo = new Cliente()
            {
                nombre = txtNombre.Text,
                dni = txtDni.Text,
                direccion = txtDirec.Text,
                email = txtEmail.Text,
                ciudad = txtCiudad.Text,
                telefono = txtTel.Text,
                codigopostal = Convert.ToInt32(txtCodPostal.Text),
            };
            string data = JsonConvert.SerializeObject(clienteNuevo);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cliente/AgregarCliente", content).Result;
            if (response.IsSuccessStatusCode)
            {
                bool clienteAgregado = JsonConvert.DeserializeObject<bool>(response.Content.ReadAsStringAsync().Result);
                if (clienteAgregado == true)
                {
                    MostrarCliente("");
                    MessageBox.Show("Cliente agregada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ya existe el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo agregar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente editarCliente = new Cliente()
            {
                clienteid = _clienteid,
                nombre = txtNombre.Text,
                dni = txtDni.Text,
                direccion = txtDirec.Text,
                email = txtEmail.Text,
                ciudad = txtCiudad.Text,
                telefono = txtTel.Text,
                codigopostal = Convert.ToInt32(txtCodPostal.Text),
            };
            string data = JsonConvert.SerializeObject(editarCliente);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cliente/EditarCliente", content).Result;
            if (response.IsSuccessStatusCode)
            {
                bool clienteAgregado = JsonConvert.DeserializeObject<bool>(response.Content.ReadAsStringAsync().Result);
                if (clienteAgregado == true)
                {
                    MostrarCliente("");
                    MessageBox.Show("Cliente Editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe un cliente con ese Dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo agregar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvClientes.Rows[e.RowIndex];
                _clienteid = Convert.ToInt32(selectedRow.Cells["clienteid"].Value.ToString());
                txtNombre.Text = selectedRow.Cells["nombre"].Value.ToString();
                txtDni.Text = selectedRow.Cells["dni"].Value.ToString();
                txtDirec.Text = selectedRow.Cells["direccion"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtTel.Text = selectedRow.Cells["telefono"].Value.ToString();
                txtCiudad.Text = selectedRow.Cells["ciudad"].Value.ToString();
                txtCodPostal.Text = selectedRow.Cells["codigopostal"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var clienteId = dgvClientes.SelectedRows[0].Cells["clienteid"].Value.ToString();
            Search cliente = new Search()
            {
                TextToSearch = clienteId
            };
            string data = JsonConvert.SerializeObject(cliente);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cliente/EliminarCliente", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            bool eliminacionExitosa = JsonConvert.DeserializeObject<bool>(jsonToDeserialize);
            if (response.IsSuccessStatusCode && eliminacionExitosa == true)
            {
                MessageBox.Show("Producto eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCliente("");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                txtPagina.Text = _currentPage.ToString();
                MostrarCliente("");
            }
        }

        private void txtPagina_TextChanged(object sender, EventArgs e)
        {
            int index;

            if (int.TryParse(txtPagina.Text, out index))
            {
                _currentPage = index;
            }
            else
            {
                _currentPage = 1;
            }
            MostrarCliente("");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _currentPage++;
            txtPagina.Text = _currentPage.ToString();
            MostrarCliente("");
        }

        private void cbItemsPorPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItemsPerPage = int.Parse(cbItemsPorPagina.SelectedItem.ToString()!);
            MostrarCliente("");
        }
        public void MostrarCliente(string buscar)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = buscar,
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cliente/MostrarCliente", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Cliente>>(jsonToDeserialize);
            dgvClientes.DataSource = result.Items;
            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MostrarCliente(txtBusar.Text);
        }
    }
}
