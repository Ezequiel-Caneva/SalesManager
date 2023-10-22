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
    public partial class FormPedidos : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        private string filtro;
        private int pedidoId;
        public FormPedidos()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 10;
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            dgvDetalle.Visible = false;
        }

        private void bntPendiente_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnDespachar.Visible = false;
            filtro = "Pendiente";
            filtrar(filtro);

        }
        private void btnConfimado_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnDespachar.Visible = true;
            dgvDetalle.Visible = false;
           
            filtro = "Confirmado";
            filtrar(filtro);


        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                e.Value = "No generada"; // O establece otro valor predeterminado
                e.FormattingApplied = true;
            }

        }

        private void dgvPedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetalle.Visible = true;
            if (e.RowIndex >= 0) // Asegúrate de que se haya hecho clic en una fila válida
            {
                pedidoId = (int)dgvPedidos.Rows[e.RowIndex].Cells["pedidoId"].Value;

                // Aquí, consulta y carga los detalles del pedido correspondiente en el dgvDetalle.
                // Puedes utilizar Entity Framework o tu método de acceso a datos para obtener los detalles.
                var detalles = ObtenerDetallesDelPedido(pedidoId);


                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Producto", typeof(string));
                dataTable.Columns.Add("Cantidad", typeof(int));
                dataTable.Columns.Add("Precio", typeof(decimal));
                dataTable.Columns.Add("Total", typeof(decimal));
                dataTable.Columns.Add("Stock", typeof(int));

                foreach (var item in detalles)
                {
                    DataRow row = dataTable.NewRow();

                    row["Producto"] = item._producto.nombre;
                    row["Cantidad"] = item.cantidad;
                    row["Precio"] = item._producto.precioventa;
                    row["Total"] = item.precio_total;
                    row["Stock"] = item._producto.stock;
                    dataTable.Rows.Add(row);

                }
                dgvDetalle.DataSource = dataTable;
                if (e.ColumnIndex == dgvDetalle.Columns["Cantidad"].Index && e.RowIndex >= 0)
                {
                    int cantidad = (int)dgvDetalle.Rows[e.RowIndex].Cells["Cantidad"].Value;
                    int stock = (int)dgvDetalle.Rows[e.RowIndex].Cells["Stock"].Value;
                    if (cantidad > stock)
                    {
                        // Establecer el color de fondo deseado para la fila
                        dgvDetalle.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        dgvDetalle.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White; // Opcional: configurar el color del texto
                    }
                    else
                    {
                        // Restaurar los colores predeterminados de la fila
                        dgvDetalle.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvDetalle.DefaultCellStyle.BackColor;
                        dgvDetalle.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgvDetalle.DefaultCellStyle.ForeColor;
                    }
                }

            }
        }
        public List<DetalleVenta> ObtenerDetallesDelPedido(int pedidoid)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = pedidoid.ToString(),
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/DetallePedido", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<DetalleVenta>>(jsonToDeserialize);
            var resutado = result.Items;
            return resutado;

        }

        private void dgvDetalle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            subPedidos detalle = new subPedidos();
            detalle.Show();
        }
        private void filtrar(string filtro)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = filtro,
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/MostrarPendientes", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Pedido>>(jsonToDeserialize);
            BindingList<Pedido> bindingList = new BindingList<Pedido>(result.Items);
            dgvPedidos.DataSource = bindingList;
            dgvPedidos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {



        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {

                _currentPage--;
                txtPagina.Text = _currentPage.ToString();
                filtrar(filtro);
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
            filtrar(filtro);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _currentPage++;
            txtPagina.Text = _currentPage.ToString();
            filtrar(filtro);
        }

        private void cbItemsPorPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItemsPerPage = int.Parse(cbItemsPorPagina.SelectedItem.ToString()!);
            filtrar(filtro);
        }

        
    }
}
