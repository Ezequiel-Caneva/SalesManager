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
    public partial class FormVentas : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        public FormVentas()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 10;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            MostrarCobros();
        }
        public void MostrarCobros()
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = "",
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/MostrarCobros", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Cobro>>(jsonToDeserialize);
            dgvCobros.DataSource = result.Items;
            dgvCobros.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

    }
}
