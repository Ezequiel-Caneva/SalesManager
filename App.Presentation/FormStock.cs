﻿using App.Entities;
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
        private readonly Uri _baseAddress = new Uri("http://mototopAPI.somee.com/api");
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
            _currentItemsPerPage = 25;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            MostrarProductosoRubro("");
            rubros = ObtenerRubros();
            cbRubro.DataSource = rubros;
            cbRubro.DisplayMember = "categoria";
            cbRubro.ValueMember = "rubroid";
            // Configura el DataGridView al cargar el formulario
            DataGridViewColumn pathColumn = dgvProducto.Columns["path"];

            if (pathColumn != null)
            {
                // Fijar el ancho de la columna 'path'
                pathColumn.Width = 150; // Cambia este valor según tu necesidad

                // Configurar para que el texto se corte si es más largo que el ancho de la celda
                pathColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                pathColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }


        //Productos
        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var rubroSeleccionado = (int)cbRubro.SelectedValue;

                Producto nuevoProducto = new Producto
                {
                    nombre = txtNombreProducto.Text,
                    codigobarra = Convert.ToInt32(txtCodigoProducto.Text),
                    precioventa = Convert.ToDecimal(txtPrecioProducto.Text),
                    stock = Convert.ToInt32(txtCantidadProducto.Text),
                    rubro = rubroSeleccionado,
                    path = txtURL.Text,
                    promocion = false
                };

                string data = JsonConvert.SerializeObject(nuevoProducto);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await _client.PostAsync($"{_client.BaseAddress}/Stock/AgregarProducto", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        mostrarProductos = true;
                        MostrarProductosoRubro("");
                        MessageBox.Show("Producto agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo agregar el producto. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        path = txtURL.Text,
                        rubro = rubroSeleccionado
                    };
                    string data = JsonConvert.SerializeObject(nuevoProducto);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/EditarProducto", content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        mostrarProductos = true;
                        MostrarProductosoRubro("");
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
                MostrarProductosoRubro("");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            mostrarProductos = true;
            MostrarProductosoRubro("");

        }
        //Fin Productos

        //Rubros
        private void btnAgregarRubro_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != "")
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
                    MostrarProductosoRubro("");

                }
                else
                {
                    MessageBox.Show("No se pudo agregar el nuevo Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void btnEditarRubro_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != "")
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
                            MostrarProductosoRubro("");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo editar el rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void btnEliminarRubro_Click(object sender, EventArgs e)
        {
            var rubro = dgvProducto.SelectedRows[0].Cells["rubroid"].Value.ToString();
            Search search = new Search()
            {
                TextToSearch = rubro
            };
            string data = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/EliminarRubro", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            bool eliminacionExitosa = JsonConvert.DeserializeObject<bool>(jsonToDeserialize);
            if (response.IsSuccessStatusCode && eliminacionExitosa == true)
            {

                MessageBox.Show("Rubro eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarProductos = true;
                MostrarProductosoRubro("");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnMostrarRubros_Click(object sender, EventArgs e)
        {
            mostrarProductos = false;
            MostrarProductosoRubro("");
        }
        //fin Rubros 

        //Paginado
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                txtPagina.Text = _currentPage.ToString();
                MostrarProductosoRubro("");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _currentPage++;
            txtPagina.Text = _currentPage.ToString();
            MostrarProductosoRubro("");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItemsPerPage = int.Parse(cbItemsPorPagina.SelectedItem.ToString()!);
            MostrarProductosoRubro("");
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

            MostrarProductosoRubro("");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            MostrarProductosoRubro(buscar);
            txtPagina.Text = "1";
        }
        //fin Paginado

        //Datagriedview

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    object pathValue = selectedRow.Cells["path"].Value;

                    if (pathValue != null)
                    {
                        txtURL.Text = pathValue.ToString();
                    }
                    else
                    {
                        txtURL.Text = string.Empty;
                    }
                }
                else
                {
                    _rubroid = (int)selectedRow.Cells["rubroid"].Value;
                    txtCategoria.Text = selectedRow.Cells["categoria"].Value.ToString();
                }
            }
        }
        private void dgvProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(mostrarProductos == true) { 
            DataGridViewRow selectedRow = dgvProducto.Rows[e.RowIndex];
            var promocionValue = selectedRow.Cells["promocion"].Value;
            int idproducto = Convert.ToInt32(selectedRow.Cells["productoid"].Value.ToString());

                if (promocionValue != null && promocionValue is bool)
                {
                    bool estaEnPromocion = (bool)promocionValue;
                    if (estaEnPromocion)
                    {
                        DialogResult result = MessageBox.Show("¿Desea sacar el producto de promoción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            var search = new Search()
                            {
                                num = idproducto,
                                TextToSearch = "",
                                PageIndex = 0,
                                PageSize = 0,
                            };
                            string json = JsonConvert.SerializeObject(search);
                            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/SacarPromocion", content).Result;
                            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                            var resultado = JsonConvert.DeserializeObject<Boolean>(jsonToDeserialize);
                            if (response.IsSuccessStatusCode && resultado == true)
                            {

                                MessageBox.Show("Se saco el producto de promocion", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mostrarProductos = true;
                                MostrarProductosoRubro("");

                            }
                            else
                            {
                                MessageBox.Show("Error al sacar el producto de promocion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea agregar el producto a promoción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Form promocion = new subpromocion(idproducto);
                            promocion.ShowDialog();
                            mostrarProductos = true;
                            MostrarProductosoRubro("");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        public void MostrarProductosoRubro(string txtbuscar)
        {
            if (mostrarProductos == true)
            {
                {
                    Search search = new Search()
                    {
                        PageIndex = _currentPage,
                        PageSize = _currentItemsPerPage,
                        TextToSearch = txtbuscar,
                    };
                    string json = JsonConvert.SerializeObject(search);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/MostrarProducto", content).Result;
                    var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<Response<Producto>>(jsonToDeserialize);
                    dgvProducto.DataSource = result.Items;
                    dgvProducto.Columns["_Rubro"].Visible = false;
                    dgvProducto.Columns["cantidadselec"].Visible = false;

                    dgvProducto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    label1.Text = "Lista de productos";
                }
            }
            else if (mostrarProductos == false)
            {
                Search search = new Search()
                {
                    PageIndex = _currentPage,
                    PageSize = _currentItemsPerPage,
                    TextToSearch = txtbuscar,
                };
                string json = JsonConvert.SerializeObject(search);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/MostrarRubro", content).Result;
                var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<Response<Rubro>>(jsonToDeserialize);
                dgvProducto.DataSource = result.Items;
                dgvProducto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                label1.Text = "Lista de Rubros";
            };


        }

     



        //Fin metodos
    }
}


