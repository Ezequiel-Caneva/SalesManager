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

        }

        private void bntPendiente_Click(object sender, EventArgs e)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = "",
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
            if (e.RowIndex >= 0) // Asegúrate de que se haya hecho clic en una fila válida
            {
                int pedidoId = (int)dgvPedidos.Rows[e.RowIndex].Cells["pedidoId"].Value;

                // Aquí, consulta y carga los detalles del pedido correspondiente en el dgvDetalle.
                // Puedes utilizar Entity Framework o tu método de acceso a datos para obtener los detalles.
                var detalles = ObtenerDetallesDelPedido(pedidoId);

              
                dgvDetalle.DataSource = detalles;
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
       
    }
}
