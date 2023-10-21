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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace App.Presentation
{
    public partial class FormStock : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        private int _productoid;
        private int _rubroid;
        List<Rubro> rubros;
        private bool mostrarProductos = true;

        public FormStock()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            rubros = new List<Rubro>();
            _currentPage = 1;
            _currentItemsPerPage = 10;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            MostrarProductosoRubro();
            rubros = ObtenerRubros();
            cbRubro.DataSource = rubros;
            cbRubro.DisplayMember = "categoria";
            cbRubro.ValueMember = "rubroid";
        }


        //Productos
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Obtén el rubro seleccionado del ComboBox.
            var rubroSeleccionado = (int)cbRubro.SelectedValue;

            Producto nuevoProducto = new Producto
            {
                nombre = txtNombreProducto.Text,
                codigobarra = Convert.ToInt32(txtCodigoProducto.Text),
                precioventa = Convert.ToDecimal(txtPrecioProducto.Text),
                stock = Convert.ToInt32(txtCantidadProducto.Text),
                rubro = rubroSeleccionado // Asigna el rubro seleccionado al producto.
            };
            string data = JsonConvert.SerializeObject(nuevoProducto);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/AgregarProducto", content).Result;
            if (response.IsSuccessStatusCode)
            {
                mostrarProductos = true;
                MostrarProductosoRubro();
                MessageBox.Show("Producto agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {

            if (dgvProducto.SelectedRows.Count > 0)
            {
                var confirmarEditar = MessageBox.Show("¿Seguro que desea editar el producto?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarEditar == DialogResult.Yes)
                {

                    var rubroSeleccionado = (int)cbRubro.SelectedValue;
                    Producto nuevoProducto = new Producto()
                    {
                        productoid = Convert.ToInt32(_productoid),
                        nombre = txtNombreProducto.Text,
                        codigobarra = Convert.ToInt32(txtCodigoProducto.Text),
                        precioventa = Convert.ToDecimal(txtPrecioProducto.Text),
                        stock = Convert.ToInt32(txtCantidadProducto.Text),
                        rubro = rubroSeleccionado
                    };
                    string data = JsonConvert.SerializeObject(nuevoProducto);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/EditarProducto", content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        mostrarProductos = true;
                        MostrarProductosoRubro();
                        MessageBox.Show("Producto editado ecorrectamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            var productoId = dgvProducto.SelectedRows[0].Cells["productoid"].Value.ToString();
            Search producto = new Search()
            {
                TextToSearch = productoId
            };
            string data = JsonConvert.SerializeObject(producto);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/EliminarProducto", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            bool eliminacionExitosa = JsonConvert.DeserializeObject<bool>(jsonToDeserialize);
            if (response.IsSuccessStatusCode && eliminacionExitosa == true)
            {

                MessageBox.Show("Producto eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarProductos = true;
                MostrarProductosoRubro();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            mostrarProductos = true;
            MostrarProductosoRubro();

        }
        //Fin Productos

        //Rubros
        private void btnAgregarRubro_Click(object sender, EventArgs e)
        {
            Rubro nuevoRubro = new Rubro()
            {
                categoria = txtCategoria.Text
            };
            string data = JsonConvert.SerializeObject(nuevoRubro);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/AgregarRubro", content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Rubro agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarProductos = false;
                MostrarProductosoRubro();

            }
            else
            {
                MessageBox.Show("No se pudo agregar el nuevo Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnEditarRubro_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                var confirmarEditar = MessageBox.Show("¿Seguro que desea editar el Rubro?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarEditar == DialogResult.Yes)
                {
                    Rubro nuevoRubro = new Rubro()
                    {
                        rubroid = Convert.ToInt32(_rubroid),
                        categoria = txtCategoria.Text

                    };
                    string data = JsonConvert.SerializeObject(nuevoRubro);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/EditarRubro", content).Result;
                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Producto editado ecorrectamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarProductos = false;
                        MostrarProductosoRubro();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnMostrarRubros_Click(object sender, EventArgs e)
        {
            mostrarProductos = false;
            MostrarProductosoRubro();
        }
        //fin Rubros 

        //Paginado
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                txtPagina.Text = _currentPage.ToString();
                MostrarProductosoRubro();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _currentPage++;
            txtPagina.Text = _currentPage.ToString();
            MostrarProductosoRubro();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItemsPerPage = int.Parse(cbItemsPorPagina.SelectedItem.ToString()!);
            MostrarProductosoRubro();
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

            MostrarProductosoRubro();
        }
        //fin Paginado

        //Datagriedview
        private void dgvProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProducto.Rows[e.RowIndex];
                if (mostrarProductos == true)
                {


                    selectedRow.Selected = true;
                    _productoid = (int)selectedRow.Cells["productoid"].Value;
                    txtNombreProducto.Text = selectedRow.Cells["nombre"].Value.ToString();
                    txtCodigoProducto.Text = selectedRow.Cells["codigobarra"].Value.ToString();
                    txtPrecioProducto.Text = selectedRow.Cells["precioventa"].Value.ToString();
                    txtCantidadProducto.Text = selectedRow.Cells["stock"].Value.ToString();
                    int rubroId = (int)selectedRow.Cells["rubro"].Value;
                    cbRubro.SelectedValue = rubroId;
                }
                else
                {
                    _rubroid = (int)selectedRow.Cells["rubroid"].Value;
                    txtCategoria.Text = selectedRow.Cells["categoria"].Value.ToString();
                }
            }
        }
        private void dgvProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        //fin Datagriedview


        //Metodos
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
        public void MostrarProductosoRubro()
        {
            if (mostrarProductos == true)
            {
                {
                    Search search = new Search()
                    {
                        PageIndex = _currentPage,
                        PageSize = _currentItemsPerPage,
                        TextToSearch = "",
                    };
                    string json = JsonConvert.SerializeObject(search);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/MostrarProducto", content).Result;
                    var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<Response<Producto>>(jsonToDeserialize);
                    dgvProducto.DataSource = result.Items;
                    dgvProducto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            else if (mostrarProductos == false)
            {
                Search search = new Search()
                {
                    PageIndex = _currentPage,
                    PageSize = _currentItemsPerPage,
                    TextToSearch = "",
                };
                string json = JsonConvert.SerializeObject(search);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/MostrarRubro", content).Result;
                var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<Response<Rubro>>(jsonToDeserialize);
                dgvProducto.DataSource = result.Items;
                dgvProducto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            };

        }
        //Fin metodos
    }
}


