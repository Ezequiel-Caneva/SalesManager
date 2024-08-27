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
    public partial class FormSolicitudes : Form
    {
        private readonly Uri _baseAddress = new Uri("http://mototopAPI.somee.com/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        public FormSolicitudes()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 25;
        }

        private void FormSolicitudes_Load(object sender, EventArgs e)
        {
            var pendiente = traerSolicitudes("Pendiente", "solicitudesPendientes");
            dgvSolicitudes.DataSource = pendiente;

        }
        public List<Solicitud> traerSolicitudes(string estado, string direc)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = estado,
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cliente/{direc}", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Solicitud>>(jsonToDeserialize);
            return result.Items;


        }

        private void bntPendiente_Click(object sender, EventArgs e)
        {
            var pendiente = traerSolicitudes("Pendiente", "solicitudesPendientes");
            dgvSolicitudes.DataSource = pendiente;
        }

        private void btnConfimado_Click(object sender, EventArgs e)
        {
            var pendiente = traerSolicitudes("Confirmado", "solicitudesPendientes");
            dgvSolicitudes.DataSource = pendiente;
        }
    }
}
