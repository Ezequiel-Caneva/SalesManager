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
    public partial class FormVentasMostrador : Form

    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        private List<Producto> _productos;
        public FormVentasMostrador()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 10;
        }



        private void FormVentasMostrador_Load(object sender, EventArgs e)
        {
            MostrarProductosoRubro("");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MostrarProductosoRubro(string txtbuscar)
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
            dgvProductos.DataSource = result.Items;
            dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }
    }
}
