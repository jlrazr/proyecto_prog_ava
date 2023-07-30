using AppCliente.Forms;
using Libreria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCliente.CapaPresentacion
{
    public partial class FormHistorialPedidos : Form
    {
        Cliente clienteActivo;
        List<Plato> platos = new();
        List<Extra> extras = new();
        List<Pedido> pedidos = new();
        public List<PedidoExtra> pedidosExtras;
        int costoExtras;
        int costoPedidos;
        int costoTotal;

        public FormHistorialPedidos(Cliente clienteActivo)
        {
            InitializeComponent();
            this.clienteActivo = clienteActivo;
        }

        private void FormHistorialPedidos_Shown(object sender, EventArgs e)
        {
            label_historial_nombre_cliente.Text = clienteActivo.Nombre + " " + clienteActivo.PrimApellido + " " + clienteActivo.SegApellido;
        }

        private void button_historial_consultar_porId_Click(object sender, EventArgs e)
        {
            try
            {
                platos = new();
                extras = new();
                pedidos = new();
                pedidosExtras = new();
                costoExtras = 0;
                costoPedidos = 0;
                costoTotal = 0;

                int idIngresado = int.Parse(textBox_historial_id_pedido.Text);

                if (idIngresado == null)
                {
                    var mensaje_errorReg = new FormMensaje("Ha ocurrido un error. Verifique los datos y vuelva a intentarlo");
                    mensaje_errorReg.ShowDialog();
                }
                else
                {
                    Conexion conexionPedido = new Conexion();
                    Pedido pedido = conexionPedido.FetchPedidoById(idIngresado);

                    Conexion conexionPlato = new Conexion();
                    Plato platoPedido = conexionPlato.FetchPlatoById(pedido.IdPlato);

                    Conexion conexionPedidoExtra = new Conexion();
                    List<PedidoExtra> _pedidosExtra = conexionPedidoExtra.FetchPedidoExtrasPorIdPedido(pedido.IdPedido);

                    if (_pedidosExtra != null && _pedidosExtra.Count > 0)
                    {
                        foreach (var pedidoExtra in _pedidosExtra)
                        {
                            Conexion conexionExtra = new Conexion();
                            Extra extra = conexionExtra.FetchExtraPorId(pedidoExtra.IdExtra);
                            extras.Add(extra);
                        }
                    }

                    pedidos.Add(pedido);
                    pedidosExtras = _pedidosExtra;
                    platos.Add(platoPedido);

                    dataGridView_historial_platos_pedido.DataSource = platos.Where(x => x != null).ToList();
                    dataGridView_historial_extras_pedido.DataSource = extras.Where(x => x != null).ToList();

                    foreach (var plato in platos)
                    {
                        costoPedidos += plato.Precio;
                    }

                    foreach (var extra in extras)
                    {
                        costoExtras += extra.Precio;
                    }

                    costoTotal = costoExtras + costoPedidos;

                    label_historial_costoPedido.Text = "Costo del Pedido: " + costoTotal + " Colones";
                }
            }
            catch (Exception ex)
            {
                var mensaje_errorReg = new FormMensaje("Ha ocurrido un error: " + ex.Message);
                mensaje_errorReg.ShowDialog();
            }
        }
    }
}
