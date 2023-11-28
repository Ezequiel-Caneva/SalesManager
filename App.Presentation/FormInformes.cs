using App.Entities;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace App.Presentation
{
    public partial class FormInformes : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool primeraFechaSeleccionada = false;
        string mostrar;


        public FormInformes()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
            new DateTime(2023, 1, 1),
            new DateTime(2023, 12, 31),
            DateTime.Today.AddDays(5)
            };
            monthCalendar1.DateSelected += MonthCalendar1_DateSelected;

            monthCalendar1.Visible = false;
            btnSeleccionar.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void dgvInformes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            mostrar = "vendedor";
            monthCalendar1.Visible = true;
            btnSeleccionar.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            var result = traerInfomacion();
            var informe = result.Items
                .Where(p => p._vendedor != null)
                .GroupBy(p => p._vendedor.vendedorid)
                .Select(group => new
                {
                    VendedorId = group.Key,
                    Dni = group.FirstOrDefault()?._vendedor?.usuario.dni,
                    NombreVendedor = group.FirstOrDefault()?._vendedor?.usuario.usuario,
                    Zona = group.FirstOrDefault()?._vendedor?.zona,
                    CantidadVentas = group.Count(),
                    TotalVendido = group.Sum(p => p._factura.montototal)
                })
                .OrderByDescending(x => x.CantidadVentas)
                .ToList();

            // Mostrar el informe en el DataGridView
            dgvInformes.DataSource = informe;
            dgvInformes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void bntVentas_Click(object sender, EventArgs e)
        {
            mostrar = "ventas";
            monthCalendar1.Visible = true;
            btnSeleccionar.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            DateTime fechaInicio = new DateTime(2023, 1, 1); // Fecha de inicio del período
            DateTime fechaFin = new DateTime(2023, 12, 31);

            var result = traerInfomacion();
            var informe = result.Items
                .Where(p => p._vendedor != null && p.fecha >= fechaInicio && p.fecha <= fechaFin)
                .Select(p => new
                {
                    Fecha = p.fecha.ToString(),
                    VentaId = p.pedidoid,
                    NombreVendedor = p._vendedor?.usuario.usuario,
                    NombreCliente = p._cliente?.nombre,
                    DniCliente = p._cliente?.dni,
                    MontoTotal = p._factura?.montototal,
                })
                .OrderByDescending(x => x.VentaId) // Opcional: puedes cambiar a otra propiedad para ordenar
                .ToList();

            // Mostrar el informe en el DataGridView
            dgvInformes.DataSource = informe;
            dgvInformes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


        public Response<Pedido> traerInfomacion()
        {
            Search search = new Search()
            {
                PageIndex = 1,
                PageSize = 40,
                TextToSearch = "Despachado",
                TextToSearch2 = "Vendido",
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Usuario/InformeVendedor", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Pedido>>(jsonToDeserialize);
            return result;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (mostrar == "ventas")
            {
                if (primeraFechaSeleccionada)
                {
                    // Informar al usuario que debe seleccionar un rango completo de fechas.
                    MessageBox.Show("Por favor, seleccione tanto la fecha de inicio como la de fin.");
                    return;
                }
                label2.Visible = true;
                label3.Visible = true;


                var result = traerInfomacion();
                var informe = result.Items
                .Where(p => p._vendedor != null && p.fecha >= fechaInicio && p.fecha <= fechaFin)
                .Select(p => new
                {
                    Fecha = p.fecha.ToString(),
                    VentaId = p.pedidoid,
                    NombreVendedor = p._vendedor?.usuario.usuario,
                    NombreCliente = p._cliente?.nombre,
                    DniCliente = p._cliente?.dni,

                    MontoTotal = p._factura?.montototal,
                })
                .OrderByDescending(x => x.VentaId) // Opcional: puedes cambiar a otra propiedad para ordenar
                .ToList();

                // Mostrar el informe en el DataGridView
                dgvInformes.DataSource = informe;
                dgvInformes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else if(mostrar == "vendedor")
            {

                if (primeraFechaSeleccionada)
                {
                    // Informar al usuario que debe seleccionar un rango completo de fechas.
                    MessageBox.Show("Por favor, seleccione tanto la fecha de inicio como la de fin.");
                    return;
                }
                label2.Visible = true;
                label3.Visible = true;

                var result = traerInfomacion();
                var informe = result.Items
                    .Where(p => p._vendedor != null && p.fecha >= fechaInicio && p.fecha <= fechaFin)
                    .GroupBy(p => new { p._vendedor.vendedorid, p._vendedor.usuario.dni, p._vendedor.usuario.usuario, p._vendedor.zona })
                    .Select(group => new
                    {
                        VendedorId = group.Key.vendedorid,
                        Dni = group.Key.dni,
                        NombreVendedor = group.Key.usuario,
                        Zona = group.Key.zona,
                        CantidadVentas = group.Count(),
                        TotalVendido = group.Sum(p => p._factura?.montototal ?? 0)
                    })
                    .OrderByDescending(x => x.CantidadVentas)
                    .ToList();
                dgvInformes.DataSource = informe;
                dgvInformes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!primeraFechaSeleccionada)
            {
                fechaInicio = e.Start;
                primeraFechaSeleccionada = true;
                label2.Text = fechaInicio.ToString();
            }
            else
            {
                fechaFin = e.Start;
                label3.Text = fechaFin.ToString();
                primeraFechaSeleccionada = false;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            Search search = new Search()
            {
                PageIndex = 1,
                PageSize = 40,
                TextToSearch = "",
                TextToSearch2 = "",
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Usuario/InformeProducto", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<DetalleVenta>>(jsonToDeserialize);


            var informe = result.Items
            .Where(detalle => detalle._producto != null)
            .GroupBy(detalle => detalle.producto)
            .Select(group => new
            {
                ProductoId = group.Key,
                NombreProducto = group.FirstOrDefault()?._producto.nombre,
                CantidadesVendidas = group.Sum(detalle => detalle.cantidad) // Sumar la cantidad de cada producto vendido
            })
            .OrderByDescending(x => x.CantidadesVendidas)
            .ToList();
            dgvInformes.DataSource = informe;
            dgvInformes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel(dgvInformes);
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
                        worksheet.Cells[i + 2, j + 1] = tabla.Rows[i].Cells[j].Value.ToString();
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

    }
    
}
