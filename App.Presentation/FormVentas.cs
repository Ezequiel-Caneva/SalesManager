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
            _currentItemsPerPage = 10;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            List<Cobro> cobros = MostrarCobros("",null);
            dgvCobros.DataSource = cobros;
          
            if(cbCliente.Text != null)
            {
                cobros = MostrarCobros(cbCliente.Text,null);
                dgvCobros.DataSource = cobros;
            }
            cbCliente.SelectedIndexChanged += (sender, e) =>
            {
                // Obtiene el cliente seleccionado
                Cliente clienteSeleccionado = (Cliente)cbCliente.SelectedItem;

                if (clienteSeleccionado != null)
                {
                    int clienteIdSeleccionado = clienteSeleccionado.clienteid;

                    // Filtra los cobros basados en el cliente seleccionado
                    List<Cobro> cobrosFiltrados = cobros.Where(c => c.cliente == clienteIdSeleccionado).ToList();

                    // Muestra los cobros en el DataGridView
                    dgvCobros.DataSource = cobrosFiltrados;

                    // Filtra las facturas basadas en los cobros filtrados
                    List<Factura> facturasFiltradas = facturas.Where(f => cobrosFiltrados.Any(c => c.nrofactura == f.nrofactura)).ToList();

                    // Actualiza el contenido del ComboBox de facturas con las facturas filtradas
                    cbFactura.DisplayMember = "nrofactura";
                    cbFactura.ValueMember = "nrofactura";
                    cbFactura.DataSource = facturasFiltradas;
                }
            };
            foreach (var cobro in cobros)
            {

                Cliente cliente = cobro._cliente;
                Factura factura = cobro._factura;

                clientes.Add(cliente);
                facturas.Add(factura);
            }

            cbCliente.DisplayMember = "nombre";
            cbCliente.ValueMember = "clienteid";
            cbCliente.DataSource = clientes;
            cbFactura.DisplayMember = "nrofactura";
            cbFactura.ValueMember = "nrofactura";
            cbFactura.DataSource = facturas;
        }
        public List<Cobro> MostrarCobros(string cliente,int? factura)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = cliente,
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cobro/MostrarCobros", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Cobro>>(jsonToDeserialize);
            return result.Items;
        }

    }
}
