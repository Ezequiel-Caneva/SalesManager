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
using System.Windows.Media;
using Excel = Microsoft.Office.Interop.Excel;

namespace App.Presentation
{
    public partial class FormVentas : Form
    {
        private readonly Uri _baseAddress = new Uri("http://mototopAPI.somee.com/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        List<Cliente> clientes;
        List<Factura> facturas;
        List<Cobro> cobros;
        public FormVentas()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            clientes = new List<Cliente>();
            facturas = new List<Factura>();
            cobros = new List<Cobro>();
            _currentPage = 1;
            _currentItemsPerPage = 200;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = "",
            };
            cobros = MostrarCobros(search);

            // Inicializa las listas de clientes y facturas
            List<string> nombresClientes = cobros.Select(c => c._cliente.nombre).Distinct().ToList();
            facturas = cobros.Select(c => c._factura).ToList();

            dgvCobros.DataSource = cobros;

            cbCliente.SelectedIndexChanged += (sender, e) =>
            {

                string nombreClienteSeleccionado = cbCliente.SelectedItem.ToString();


                List<Cobro> cobrosFiltrados = cobros.Where(c => c._cliente.nombre == nombreClienteSeleccionado).ToList();

                // Muestra los cobros en el DataGridView
                dgvCobros.DataSource = cobrosFiltrados;

                // Filtra las facturas basadas en los cobros filtrados
                List<Factura> facturasFiltradas = facturas.Where(f => cobrosFiltrados.Any(c => c.nrofactura == f.nrofactura)).ToList();
                facturasFiltradas = facturasFiltradas
                .GroupBy(f => f.nrofactura)
                .Select(group => group.First())
                .ToList();
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
            Random random = new Random();
            int numero = random.Next(1, 1000);

            int numeroFacturaSeleccionado = (int)cbFactura.SelectedValue;
            var cobrosFactura = cobros.Where(c => c.nrofactura == numeroFacturaSeleccionado).ToList();
            decimal? saldoFactura = cobrosFactura.Min(c => c.saldo);
            decimal? montoPago = Convert.ToInt32(txtMonto.Text);
            var selecCobro = new Cobro();
            if (montoPago > saldoFactura)
            {
                // El pago excede el saldo de la factura.
                MessageBox.Show("El pago excede el saldo de la factura.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                saldoFactura = saldoFactura - montoPago;
                // Puedes imprimir el saldo restante después del pago.
                MessageBox.Show("Saldo restante de la factura: " + saldoFactura, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            string nombreClienteSeleccionado = cbCliente.SelectedValue.ToString();
            var cliente = cobros.FirstOrDefault(c => c._cliente.nombre == nombreClienteSeleccionado);
            int clienteid = cliente._cliente.clienteid;
            decimal monto;
            if (decimal.TryParse(txtMonto.Text, out monto))
            {
                // La conversión fue exitosa, ahora puedes crear el objeto 'Cobro'.
                Cobro cobro = new Cobro()
                {
                    fecha = DateTime.Now,
                    nrofactura = (int)cbFactura.SelectedValue,
                    cliente = clienteid,
                    tipo_comprobante = "CP",
                    nro_comprobante = numero,
                    metodopago = cbMetodo.Text,
                    credito = monto,
                    saldo = saldoFactura
                };
                string data = JsonConvert.SerializeObject(cobro);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cobro/AgregarPago", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    bool pago = JsonConvert.DeserializeObject<bool>(response.Content.ReadAsStringAsync().Result);
                    if (pago == true)
                    {
                        MessageBox.Show("Pago Correcto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Search search = new Search()
                        {
                            PageIndex = _currentPage,
                            PageSize = _currentItemsPerPage,
                            TextToSearch = "",
                            num = (int)cbFactura.SelectedValue,
                        };
                        cobros = MostrarCobros(search);
                        dgvCobros.DataSource = cobros;
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al realizar Pago1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                // Realiza la operación con el objeto 'cobro' como se requiera.
            }
            else
            {
                // El valor en 'txtMonto.Text' no es un número válido.
                MessageBox.Show("El valor ingresado en 'txtMonto' no es válido.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void ExportarExcel(DataGridView tabla)
        {
            try
            {
                // Crear una aplicación de Excel.
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Crear un nuevo libro de Excel y hoja de trabajo.
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets[1];

                // Encabezados de columna.
                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = tabla.Columns[i].HeaderText;
                }

                // Datos del DataGridView.
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < tabla.Columns.Count; j++)
                    {
                        object valorCelda = tabla.Rows[i].Cells[j].Value;
                        worksheet.Cells[i + 2, j + 1] = valorCelda != null ? valorCelda.ToString() : string.Empty;
                    }
                }

                // Liberar recursos.
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel(dgvCobros);
        }
    }
}