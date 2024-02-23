using App.Entities;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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
    public partial class Ventas : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        public int pedidoId = 0;
        public Response<Pedido> pedidos { get; set; }
        public Ventas()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 25;
            pedidos = new Response<Pedido>();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

            pedidos = filtrar("Despachado", "Vendido");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Fecha", typeof(string));
            dataTable.Columns.Add("Venta Id", typeof(int));
            dataTable.Columns.Add("Cliente", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Dni", typeof(string));
            dataTable.Columns.Add("Vendedor", typeof(int));
            dataTable.Columns.Add("Factura", typeof(int));
            dataTable.Columns.Add("MontoTotal", typeof(decimal));

            foreach (var item in pedidos.Items)
            {
                DataRow row = dataTable.NewRow();
                row["Fecha"] = item.fecha.ToString();
                row["Venta Id"] = item.pedidoid;
                row["Cliente"] = item.cliente;
                row["Nombre"] = item._cliente.nombre;
                row["Dni"] = item._cliente.dni;
                row["Vendedor"] = item.vendedor;
                row["Factura"] = item.factura;
                row["MontoTotal"] = item._factura.montototal;


                dataTable.Rows.Add(row);

            }
            dgvVentas.DataSource = dataTable;
            dgvVentas.AllowUserToAddRows = false;

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                txtPagina.Text = _currentPage.ToString();
                filtrar("Despachado", "Vendido");
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
            filtrar("Despachado", "Vendido");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _currentPage++;
            txtPagina.Text = _currentPage.ToString();
            filtrar("Despachado", "Vendido");
        }

        private void cbItemsPorPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItemsPerPage = int.Parse(cbItemsPorPagina.SelectedItem.ToString()!);
            filtrar("Despachado", "Vendido");
        }
        private Response<Pedido> filtrar(string filtro, string filtro2)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = filtro,
                TextToSearch2 = filtro2,
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/MostrarPedidos", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Pedido>>(jsonToDeserialize);
            return result;
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (pedidoId != 0)
            {
                Search search = new Search()
                {
                    PageIndex = _currentPage,
                    PageSize = _currentItemsPerPage,
                    TextToSearch = pedidoId.ToString(),
                     TextToSearch2 = "",
                     num = 0

                };
                string json = JsonConvert.SerializeObject(search);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/ObtenerPedido", content).Result;
                var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<Pedido>(jsonToDeserialize);

                // Verificar si hay detalles de venta en el resultado
                if (result._venta != null && result._venta.Any())
                {
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = $"Fac {DateTime.Now.ToString("dd MM yyyy")}.pdf";
                    string PaginaHTML_Texto = Properties.Resources.Plantilla1.ToString();
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", result._cliente.nombre);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", result._cliente.dni);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", result._factura.fecha.ToString("dd/MM/yyyy"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NRO", result._factura.nrofactura.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", result._factura.montototal.ToString());

                    string filas = string.Empty;

                    foreach (var enlistar in result._venta)
                    {
                        filas += "<tr>";
                        filas += "<td style=\"font-size: small;\">" + enlistar.cantidad.ToString() + "</td>";
                        filas += "<td style=\"font-size: small;\">" + enlistar._producto.nombre + "</td>";
                        filas += "<td style=\"font-size: small;\">" + enlistar._producto.precioventa.ToString() + "</td>";
                        filas += "<td style=\"font-size: small;\">" + enlistar.precio_total.ToString() + "</td>";
                        filas += "</tr>";
                    }

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                        {
                            // Creamos un nuevo documento y lo definimos como PDF
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(new Phrase(""));

                            // Utilizamos StringReader para leer el HTML con las filas ya formateadas
                            using (StringReader sr = new StringReader(PaginaHTML_Texto))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                            stream.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El pedido no tiene detalles de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVentas.Rows[e.RowIndex].Cells["Venta Id"].Value != DBNull.Value)
            {
                pedidoId = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["Venta Id"].Value);
                // Resto de tu código aquí...
            }
        }
    }
}
