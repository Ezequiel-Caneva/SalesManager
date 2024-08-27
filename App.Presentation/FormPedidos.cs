using App.Entities;
using FontAwesome.Sharp;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
namespace App.Presentation
{
    public partial class FormPedidos : Form
    {
        private readonly Uri _baseAddress = new Uri("http://mototopAPI.somee.com/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        private string filtro;
        public int pedidoId = 0;
        private bool autorizar = false;

        public FormPedidos()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 25;
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            btnVer.Visible = false;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnDespachar.Visible = false;
            btnFactura.Visible = false;
            dgvDetalle.Visible = false;
            btnExportar.Visible = false;
            filtro = "Pendiente";
            filtrar(filtro);

        }

        private void bntPendiente_Click(object sender, EventArgs e)
        {
            btnVer.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnDespachar.Visible = false;
            btnFactura.Visible = false;
            filtro = "Pendiente";
            btnExportar.Visible = false;
            filtrar(filtro);

        }
        private void btnConfimado_Click(object sender, EventArgs e)
        {
            btnExportar.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnDespachar.Visible = true;
            btnVer.Visible = false;
            btnFactura.Visible = true;
            dgvDetalle.Visible = false;
            filtro = "Confirmado";
            filtrar(filtro);
        }
        private void btnDespachado_Click(object sender, EventArgs e)
        {
            btnVer.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnDespachar.Visible = false;
            btnFactura.Visible = true;
            dgvDetalle.Visible = false;
            filtro = "Despachado";
            filtrar(filtro);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (pedidoId != 0)
            {
                if (autorizar == true)
                {
                    var confirmarEditar = MessageBox.Show("¿Seguro que desea confirmar este pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmarEditar == DialogResult.Yes)
                    {
                        Random random = new Random();
                        int numero = random.Next(1, 1000);
                        Search search = new Search()
                        {
                            PageIndex = _currentPage,
                            PageSize = _currentItemsPerPage,
                            TextToSearch = pedidoId.ToString()
                        };
                        string json = JsonConvert.SerializeObject(search);
                        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/ObtenerPedido", content).Result;
                        var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                        var result = JsonConvert.DeserializeObject<Pedido>(jsonToDeserialize);
                        decimal montototal = 0;

                        foreach (var item in result._venta)
                        {
                            montototal = montototal + item.precio_total;
                        }
                        result.factura = numero;
                        result.estado = "Confirmado";
                        result._factura = new Factura()
                        {
                            montototal = montototal,
                            fecha = DateTime.Now,
                            nrofactura = numero,
                            cobrado = false,
                        };
                        result._venta = null;

                        Boolean confirmado = CambiarEstado(result);
                        if (confirmado == true)
                        {
                            MessageBox.Show("Pedido Confirmado", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Confirmado el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        filtrar(filtro);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo confirmar el pedido por falta de stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (pedidoId != 0)
            {
                var confirmarEditar = MessageBox.Show("¿Desea cancelar por falta de stock o eliminar pedido?", "Confirmar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (confirmarEditar == DialogResult.Yes)
                {

                    Pedido pedido = new Pedido()
                    {
                        pedidoid = pedidoId,
                        estado = "Rechazado",
                    };
                    bool cancelar = CambiarEstado(pedido);
                    if (cancelar == true)
                    {
                        MessageBox.Show("Pedido cancelado", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cancelar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (pedidoId != 0)
            {
                var confirmarEditar = MessageBox.Show("¿Desea despachar el pedido?", "Confirmar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (confirmarEditar == DialogResult.Yes)
                {
                    Pedido pedido = new Pedido()
                    {
                        pedidoid = pedidoId,
                        estado = "Despachado",
                    };
                    Envio _envio = new Envio()
                    {
                        pedido = pedidoId
                    };
                    subEnvios envio = new subEnvios(_envio);
                    envio.ShowDialog();
                    envio.Close();
                    bool despachar = CambiarEstado(pedido);
                    if (despachar == true)
                    {
                        MessageBox.Show("Pedido despachado", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo despachar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (pedidoId != 0)
            {
                Search search = new Search()
                {
                    PageIndex = _currentPage,
                    PageSize = _currentItemsPerPage,
                    TextToSearch = pedidoId.ToString()
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
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (pedidoId != 0)
            {
                subMostrarEnvio mostrar = new subMostrarEnvio(pedidoId);
                mostrar.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Paginado
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
        // Fin Paginado
        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetalle.Visible = true;
            if (e.RowIndex >= 0) // Asegúrate de que se haya hecho clic en una fila válida
            {
                pedidoId = (int)dgvPedidos.Rows[e.RowIndex].Cells["Id"].Value;

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
                foreach (var item in detalles)
                {
                    if (item.cantidad <= item._producto.stock)
                    {
                        autorizar = true;
                    }
                    else
                    {
                        autorizar = false;
                    }
                }
                dgvDetalle.DataSource = dataTable;
                if (!autorizar)
                {
                    foreach (DataGridViewRow row in dgvDetalle.Rows)
                    {
                        if (row.Cells["Cantidad"].Value != null && row.Cells["Stock"].Value != null)
                        {
                            int cantidad = (int)row.Cells["Cantidad"].Value;
                            int stock = (int)row.Cells["Stock"].Value;

                            if (cantidad > stock)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                row.DefaultCellStyle.ForeColor = Color.White;
                            }
                        }
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
        private void filtrar(string filtro)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = filtro,
                TextToSearch2 = "",
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/MostrarPedidos", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Pedido>>(jsonToDeserialize);
            BindingList<Pedido> bindingList = new BindingList<Pedido>(result.Items);
            dgvPedidos.DataSource = bindingList;
            dgvPedidos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPedidos.AllowUserToAddRows = false;
        }
        public Boolean CambiarEstado(Pedido pedido)
        {
            string json = JsonConvert.SerializeObject(pedido);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/{pedido.estado}", content).Result;
            var cambiado = JsonConvert.DeserializeObject<Boolean>(response.Content.ReadAsStringAsync().Result);
            return cambiado;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel(dgvPedidos);
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
