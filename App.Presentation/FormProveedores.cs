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
    public partial class FormProveedores : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        private int _proveedorid;
        public FormProveedores()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 10;

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedores();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor()
            {

                nombre = txtNombreProv.Text,
                direccion = txtDirecProv.Text,
                razonsocial = txtRzProv.Text,
                telefono = txtTelProv.Text,
            };
            string data = JsonConvert.SerializeObject(proveedor);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Proveedor/AgregarProveedor", content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Producto agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarProveedores();

            }
            else
            {
                MessageBox.Show("No se pudo agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                var confirmarEditar = MessageBox.Show("¿Seguro que desea editar el Rubro?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarEditar == DialogResult.Yes)
                {
                    Proveedor nuevoProveedor = new Proveedor()
                    {
                        proveedorid = _proveedorid,
                        nombre = txtNombreProv.Text,
                        direccion = txtDirecProv.Text,
                        telefono = txtTelProv.Text,
                        razonsocial = txtRzProv.Text,
                    };
                    string data = JsonConvert.SerializeObject(nuevoProveedor);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Proveedor/EditarProveedor", content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Proveedor editado ecorrectamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void MostrarProveedores()
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = "",
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Proveedor/MostrarProveedor", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Proveedor>>(jsonToDeserialize);
            dgvProveedores.DataSource = result.Items;
            dgvProveedores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                txtPagina.Text = _currentPage.ToString();
                MostrarProveedores();
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
            MostrarProveedores();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _currentPage++;
            txtPagina.Text = _currentPage.ToString();
            MostrarProveedores();
        }

        private void cbItemsPorPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItemsPerPage = int.Parse(cbItemsPorPagina.SelectedItem.ToString()!);
            MostrarProveedores();
        }

        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProveedores.Rows[e.RowIndex];
                _proveedorid = Convert.ToInt32(selectedRow.Cells["proveedorid"].Value.ToString());
                txtNombreProv.Text = selectedRow.Cells["nombre"].Value.ToString();
                txtDirecProv.Text = selectedRow.Cells["direccion"].Value.ToString();
                txtRzProv.Text = selectedRow.Cells["razonsocial"].Value.ToString();
                txtTelProv.Text = selectedRow.Cells["telefono"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var proveedorId = dgvProveedores.SelectedRows[0].Cells["proveedorid"].Value.ToString();
            Search proveedor = new Search()
            {
                TextToSearch = proveedorId
            };
            string data = JsonConvert.SerializeObject(proveedor);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Proveedor/EliminarProveedor", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            bool eliminacionExitosa = JsonConvert.DeserializeObject<bool>(jsonToDeserialize);
            if (response.IsSuccessStatusCode && eliminacionExitosa == true)
            {
                MessageBox.Show("Producto eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarProveedores();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTelProv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_Click(object sender, EventArgs e)
        {
        }

        private void Texto5_Click(object sender, EventArgs e)
        {
        }

        private void txt2_Click(object sender, EventArgs e)
        {
        }

        private void txtRzProv_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt1_Click(object sender, EventArgs e)
        {
        }
        private void txtNombreProv_TextChanged(object sender, EventArgs e)
        {
        }

        private void Text1_Click(object sender, EventArgs e)
        {
        }

        private void txtDirecProv_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void labelcontenedor_Click(object sender, EventArgs e)
        {
        }

        private void txt6_Click(object sender, EventArgs e)
        {
        }
    }
}
