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
    public partial class FormCompras : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        public int _proveedorid;
        public int _productoid;
        List<Proveedor> proveedores;
        List<Producto> productos;
        List<Rubro> rubro;

        public FormCompras()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            proveedores = new List<Proveedor>();
            productos = new List<Producto>();
            rubro = new List<Rubro>();
            _currentPage = 1;
            _currentItemsPerPage = 25;
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            MostrarCompras();
            rubro = ObtenerRubros();
            proveedores = ObtenerProveedores();
            productos = ObtenerProductos();
            CbProveedor.DataSource = proveedores;
            CbProveedor.DisplayMember = "razonsocial";
            CbProveedor.ValueMember = "proveedorid";
            cbRubro.DataSource = rubro;
            cbRubro.DisplayMember = "categoria";
            cbRubro.ValueMember = "rubroid";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleCompra detalleCompra = new DetalleCompra()
            {
                nombreproducto = cbProducto.Text,
                cantidad = Convert.ToInt32(txtCantidad.Text),
                preciocompra = Convert.ToDecimal(txtPrecioComp.Text),
                proveedor = CbProveedor.Text,
                productoid = (int)cbProducto.SelectedValue,
                proveedorid = (int)CbProveedor.SelectedValue,

            };
            string data = JsonConvert.SerializeObject(detalleCompra);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Compra/CargarCompra", content).Result;
            if (response.IsSuccessStatusCode)
            {

                MessageBox.Show("Compra agregada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo cargar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                var confirmarEditar = MessageBox.Show("¿Seguro que desea editar esta Compra?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarEditar == DialogResult.Yes)
                {

                    Producto nuevoProducto = new Producto()
                    {

                    };
                    string data = JsonConvert.SerializeObject(nuevoProducto);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Stock/EditarCompra", content).Result;
                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Producto editado ecorrectamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }
        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCompras.Rows[e.RowIndex];
                _productoid = (int)selectedRow.Cells["productoid"].Value;
                _proveedorid = (int)selectedRow.Cells["proveedorid"].Value;
                txtCantidad.Text = selectedRow.Cells["cantidad"].Value.ToString();
                txtPrecioComp.Text = selectedRow.Cells["preciocompra"].Value.ToString();
                int productoId = (int)selectedRow.Cells["productoid"].Value;
                int proveedorId = (int)selectedRow.Cells["proveedorid"].Value;

                // Establecer los valores seleccionados de los ComboBox
                cbProducto.SelectedValue = productoId;
                CbProveedor.SelectedValue = proveedorId;
            }
        }

        public void MostrarCompras()
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = "",
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Compra/MostrarCompras", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<DetalleCompra>>(jsonToDeserialize);
            dgvCompras.DataSource = result.Items;
            dgvCompras.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public List<Proveedor> ObtenerProveedores()
        {
            HttpResponseMessage response = _client.GetAsync($"{_client.BaseAddress}/Proveedor/ObtenerProveedores").Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                var preveedores = JsonConvert.DeserializeObject<List<Proveedor>>(jsonToDeserialize);

                return preveedores;
            }
            return null;

        }
        public List<Producto> ObtenerProductos()
        {
            HttpResponseMessage response = _client.GetAsync($"{_client.BaseAddress}/Stock/ObtenerProductos").Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                var productos = JsonConvert.DeserializeObject<List<Producto>>(jsonToDeserialize);

                return productos;
            }
            return null;
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

        private void cbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rubro rubroSeleccionado = (Rubro)cbRubro.SelectedItem;
            int rubroId = rubroSeleccionado.rubroid;
            // Filtra la lista de productos en función del rubro seleccionado
            List<Producto> productosFiltrados = productos
                .Where(producto => producto.rubro == rubroId)
                .ToList();
            cbProducto.DataSource = null;
            // Limpia el ComboBox de productos
            cbProducto.Items.Clear();
            cbProducto.DisplayMember = "nombre";
            cbProducto.ValueMember = "productoid";
            // Agrega los productos filtrados al ComboBox de productos
            cbProducto.Items.AddRange(productosFiltrados.ToArray());
            cbProducto.DataSource = productosFiltrados;

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                txtPagina.Text = _currentPage.ToString();
                MostrarCompras();
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
            MostrarCompras();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _currentPage++;
            txtPagina.Text = _currentPage.ToString();
            MostrarCompras();
        }

        private void cbItemsPorPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItemsPerPage = int.Parse(cbItemsPorPagina.SelectedItem.ToString()!);
            MostrarCompras();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DetalleCompra eliminar = new DetalleCompra()
            {
                productoid = _productoid,
                proveedorid = _proveedorid
            };

            string data = JsonConvert.SerializeObject(eliminar);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Compra/EliminarCompra", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            bool eliminacionExitosa = JsonConvert.DeserializeObject<bool>(jsonToDeserialize);
            if (response.IsSuccessStatusCode && eliminacionExitosa == true)
            {
                MessageBox.Show("Compra eliminada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCompras();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
