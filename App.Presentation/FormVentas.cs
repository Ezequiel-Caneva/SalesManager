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
        List<Cliente> clientes;
        List<Factura> facturas;
        public FormVentas()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            clientes = new List<Cliente>();
            facturas = new List<Factura>();
            _currentPage = 1;
            _currentItemsPerPage = 25;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = "",
            };
            List<Cobro> cobros = MostrarCobros(search);

            // Inicializa las listas de clientes y facturas
            List<string> nombresClientes = cobros.Select(c => c._cliente.nombre).Distinct().ToList();
            List<Factura> facturas = cobros.Select(c => c._factura).ToList();

            dgvCobros.DataSource = cobros;

            cbCliente.SelectedIndexChanged += (sender, e) =>
            {

                string nombreClienteSeleccionado = cbCliente.SelectedItem.ToString();

                // Filtra los cobros basados en el nombre del cliente seleccionado
                List<Cobro> cobrosFiltrados = cobros.Where(c => c._cliente.nombre == nombreClienteSeleccionado).ToList();

                // Muestra los cobros en el DataGridView
                dgvCobros.DataSource = cobrosFiltrados;

                // Filtra las facturas basadas en los cobros filtrados
                List<Factura> facturasFiltradas = facturas.Where(f => cobrosFiltrados.Any(c => c.nrofactura == f.nrofactura)).ToList();

                // Actualiza el contenido del ComboBox de facturas con las facturas filtradas
                cbFactura.DisplayMember = "nrofactura";
                cbFactura.ValueMember = "nrofactura";
                cbFactura.DataSource = facturasFiltradas;
            };

            cbCliente.DisplayMember = "nombre";
            cbCliente.ValueMember = "clienteid";
            cbCliente.DataSource = nombresClientes;

            cbFactura.DisplayMember = "nrofactura";
            cbFactura.ValueMember = "nrofactura";
            cbFactura.DataSource = facturas;

            cbFactura.SelectedIndexChanged += (sender, e) =>
            {
                string nombreCliente = cbCliente.SelectedValue.ToString();
                int numeroFactura = (int)cbFactura.SelectedValue;
                search.TextToSearch = nombreCliente;
                search.num = numeroFactura;
                List<Cobro> cobro = MostrarCobros(search);
                dgvCobros.DataSource = cobro;

            };
            dgvCobros.Columns["_cliente"].Visible = false;
            dgvCobros.Columns["_factura"].Visible = false;
        }
        public List<Cobro> MostrarCobros(Search search)
        {
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cobro/MostrarCobros", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Cobro>>(jsonToDeserialize);
            return result.Items;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {

        }
    }
}
