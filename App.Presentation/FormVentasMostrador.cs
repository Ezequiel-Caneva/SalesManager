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
using System.Windows.Forms;

namespace App.Presentation
{
    public partial class FormVentasMostrador : Form

    {
        private readonly Uri _baseAddress = new Uri("http://mototopAPI.somee.com/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        private List<Producto> _productos;
        private List<Producto> _productosListados;
        private Producto _producto;
        private int productoid;
        private int _listadoid;
        Usuario _usuario;

        public FormVentasMostrador(Usuario usuarioLogeado)
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 20;
            _productos = new List<Producto>();
            _productosListados = new List<Producto>();
            _producto = new Producto();
            _usuario = new Usuario();


        }

        private void FormVentasMostrador_Load(object sender, EventArgs e)
        {

            _productos = FiltrarProductos("");
            Mostrar(_productos);


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (productoid != 0)
            {
                Producto productoEncontrado = _productos.FirstOrDefault(p => p.productoid == productoid);
                int cantidadSeleccionada = 0;
                if (productoEncontrado != null)
                {
                    // Mostrar el cuadro de diálogo para seleccionar la cantidad
                    using (CantidadForm cantidadForm = new CantidadForm())
                    {
                        if (cantidadForm.ShowDialog() == DialogResult.OK)
                        {
                            cantidadSeleccionada = cantidadForm.CantidadSeleccionada;
                            MessageBox.Show($"Producto: {productoEncontrado.nombre}\n Cantidad seleccionada: {cantidadSeleccionada}", "Detalle del producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                productoEncontrado.cantidadselec = cantidadSeleccionada;
                _productosListados.Add(productoEncontrado);
                listar(_productosListados);
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (productoid != null)
            {
                Producto productoEncontrado = _productos.FirstOrDefault(p => p.productoid == _listadoid);
                _productosListados.Remove(productoEncontrado);
                listar(_productosListados);
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                productoid = (int)dgvProductos.Rows[e.RowIndex].Cells["Nro"].Value;
               
            }

        }
        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _listadoid = (int)dgvLista.Rows[e.RowIndex].Cells["Nro"].Value;
                
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            _productos = FiltrarProductos(txtBuscar.Text);
            Mostrar(_productos);

        }
        public List<Producto> FiltrarProductos(string txtbuscar)
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
            return result.Items;
        }

        public void listar(List<Producto> lista)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nro", typeof(int));
            dataTable.Columns.Add("Producto", typeof(string));
            dataTable.Columns.Add("Cantidad", typeof(int));
            dataTable.Columns.Add("Precio", typeof(decimal));

            foreach (var item in lista)
            {
                DataRow row = dataTable.NewRow();
                row["Nro"] = item.productoid;
                row["Producto"] = item.nombre;
                row["Cantidad"] = item.cantidadselec;
                row["Precio"] = item.precioventa;

                dataTable.Rows.Add(row);

            }
            dgvLista.DataSource = dataTable;
        }
        public void Mostrar(List<Producto> productos)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nro", typeof(int));
            dataTable.Columns.Add("Producto", typeof(string));
            dataTable.Columns.Add("Stock", typeof(int));
            dataTable.Columns.Add("Precio", typeof(decimal));
            dataTable.Columns.Add("Categoria", typeof(string));
            foreach (var item in productos)
            {
                DataRow row = dataTable.NewRow();
                row["Nro"] = item.productoid;
                row["Producto"] = item.nombre;
                row["Stock"] = item.stock;
                row["Precio"] = item.precioventa;
                row["Categoria"] = item._Rubro.categoria;
                dataTable.Rows.Add(row);

            }
            dgvProductos.DataSource = dataTable;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                txtPagina.Text = _currentPage.ToString();
                _productos = FiltrarProductos("");
                Mostrar(_productos);
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
            _productos = FiltrarProductos("");
            Mostrar(_productos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _currentPage++;
            txtPagina.Text = _currentPage.ToString();
            _productos = FiltrarProductos("");
            Mostrar(_productos);
        }

        private void cbItemsPorPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItemsPerPage = int.Parse(cbItemsPorPagina.SelectedItem.ToString()!);
            _productos = FiltrarProductos("");
            Mostrar(_productos);
        }

        private void btnCtaCtes_Click(object sender, EventArgs e)
        {
            if(_productosListados != null)
            {
                Form ventasMostrador = new subVentasMostrador(_productosListados, _usuario);
                ventasMostrador.ShowDialog();

            }
        }
    }
}
public class CantidadForm : Form
{
    private NumericUpDown numericUpDownCantidad;
    private Button buttonAceptar;

    public int CantidadSeleccionada => (int)numericUpDownCantidad.Value;

    public CantidadForm()
    {
        Size = new Size(200, 150);
        numericUpDownCantidad = new NumericUpDown
        {
            Location = new Point(50, 20), // Alineación personalizada
            Size = new Size(100, 20)
        };

        buttonAceptar = new Button
        {
            Text = "Aceptar",
            Location = new Point(70, 60), // Alineación personalizada
            Size = new Size(60, 30)
        };

        buttonAceptar.Click += (sender, e) => { DialogResult = DialogResult.OK; Close(); };

        Controls.Add(numericUpDownCantidad);
        Controls.Add(buttonAceptar);
        AcceptButton = buttonAceptar;

        StartPosition = FormStartPosition.CenterScreen;
    }
}
