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

namespace App.Presentation
{
    public partial class FormPedidos : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
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
            _currentItemsPerPage = 10;
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            btnVer.Visible = false;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnDespachar.Visible = false;
            btnFactura.Visible = false;
            dgvDetalle.Visible = false;

        }

        private void bntPendiente_Click(object sender, EventArgs e)
        {
            btnVer.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnDespachar.Visible = false;
            btnFactura.Visible = false;
            filtro = "Pendiente";
            filtrar(filtro);

        }
        private void btnConfimado_Click(object sender, EventArgs e)
        {

            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnDespachar.Visible = true;
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
                subFactura detalle = new subFactura(pedidoId);
                detalle.Show();

            }
            else
            {
                MessageBox.Show("Seleccione un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                pedidoId = (int)dgvPedidos.Rows[e.RowIndex].Cells["pedidoId"].Value;

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
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/MostrarPedidos", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Pedido>>(jsonToDeserialize);
            BindingList<Pedido> bindingList = new BindingList<Pedido>(result.Items);
            dgvPedidos.DataSource = bindingList;
            dgvPedidos.Columns["_factura"].Visible = false;
            dgvPedidos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        public Boolean CambiarEstado(Pedido pedido)
        {
            string json = JsonConvert.SerializeObject(pedido);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/{pedido.estado}", content).Result;
            var cambiado = JsonConvert.DeserializeObject<Boolean>(response.Content.ReadAsStringAsync().Result);
            return cambiado;
        }




    }
}
