using AppCliente.CapaPresentacion;
using AppCliente.Forms;
using Libreria.Clases;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Sockets;

namespace AppCliente
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            button_cliente_logout.Enabled = false;
            button_anadir_platos.Enabled = false;
            button_anadir_extras.Enabled = false;
            button_hacer_pedido.Enabled = false;
            comboBox_lista_restaurantes.Enabled = false;
            button_consul_pedidos.Enabled = false;
        }

        Boolean logueado = false;
        private List<Restaurante> restaurantes;
        private List<Plato> platosElegidos = new();
        private List<Extra> extrasElegidas = new();
        private Cliente clienteActivo;
        private int precioPlatos = 0;
        private int precioExtras = 0;
        private int precioTotal = 0;
        private List<Pedido> pedidosRealizados = new();


        private void button_cliente_login_Click(object sender, EventArgs e)
        {

            //Verifica que el ID exista y que el input no sea null
            try
            {
                int idIngresado = int.Parse(textBox_cliente_id_login.Text);

                if (idIngresado == null)
                {
                    var mensaje_errorReg = new FormMensaje("Ha ocurrido un error. Verifique los datos y vuelva a intentarlo");
                    mensaje_errorReg.ShowDialog();
                }
                else
                {
                    Conexion conexion = new Conexion();
                    var response = conexion.ValidateClientId(idIngresado);


                    Cliente clienteConectado = new(response.Nombre, response.PrimApellido, response.SegApellido, response.FechaNacimiento, response.Genero);
                    clienteConectado.Id = response.Id;

                    if (response != null)
                    {
                        label_cliente.Text = "Cliente: " + clienteConectado.Nombre + " " + clienteConectado.PrimApellido + " " + clienteConectado.SegApellido;
                        clienteActivo = clienteConectado;

                        logueado = !logueado;
                        button_cliente_login.Enabled = false;
                        button_cliente_logout.Enabled = false;
                        textBox_cliente_id_login.Enabled = false;
                        textBox_cliente_id_login.Text = "";
                        button_cliente_logout.Enabled = true;
                        button_anadir_platos.Enabled = true;
                        button_anadir_extras.Enabled = true;
                        comboBox_lista_restaurantes.Enabled = true;
                        button_consul_pedidos.Enabled = true;
                    }
                    else
                    {
                        label_cliente.Text = "Cliente: No existe un cliente con el ID ingresado";
                    }
                }

                restaurantes = new Conexion().FetchAllRestaurantes();
                comboBox_lista_restaurantes.DataSource = restaurantes.Where(x => x != null && x.Estado == true).ToList();
                comboBox_lista_restaurantes.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                var mensaje_errorReg = new FormMensaje("Ha ocurrido un error: " + ex.Message);
                mensaje_errorReg.ShowDialog();
            }
        }

        private void button_cliente_logout_Click(object sender, EventArgs e)
        {
            platosElegidos = new List<Plato>();
            extrasElegidas = new List<Extra>();
            precioPlatos = 0;
            precioExtras = 0;
            precioTotal = 0;
            logueado = !logueado;
            button_cliente_login.Enabled = true;
            textBox_cliente_id_login.Enabled = true;
            button_cliente_logout.Enabled = false;
            button_anadir_platos.Enabled = false;
            button_anadir_extras.Enabled = false;
            dataGridView_platos_disponibles.DataSource = null;
            dataGridView_extras_disponibles.DataSource = null;
            dataGridView_platos_elegidos.DataSource = null;
            dataGridView_extras_elegidas.DataSource = null;
            label_cliente.Text = "Cliente:";
            label_precio_total.Text = "Costo del Pedido: 0 colones";
            button_hacer_pedido.Enabled = false;
            comboBox_lista_restaurantes.Enabled = false;
            comboBox_lista_restaurantes.DataSource = new List<Restaurante>();
            pedidosRealizados = new List<Pedido>();
            button_consul_pedidos.Enabled = false;
        }

        private void comboBox_lista_restaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_platos_disponibles.DataSource = new List<Plato>();
            dataGridView_extras_disponibles.DataSource = new List<Extra>();
            dataGridView_platos_elegidos.DataSource = new List<Plato>();
            dataGridView_extras_elegidas.DataSource = new List<Extra>();
            label_precio_total.Text = "Costo del Pedido: 0 colones";
            platosElegidos = new List<Plato>();
            extrasElegidas = new List<Extra>();
            precioPlatos = 0;
            precioExtras = 0;
            precioTotal = 0;


            if (comboBox_lista_restaurantes.SelectedItem != null && comboBox_lista_restaurantes.SelectedItem is Restaurante restauranteSeleccionado)
            {
                int idRestSeleccionado = restauranteSeleccionado.Id;
                List<Plato> platos = new();

                var restaurante = new Conexion().FetchRestauranteById(idRestSeleccionado);
                var listaIdsPlatos = new List<int>();
                if (restaurante != null) //Ojo que podr�a venir nulo y generar errores. Ver mas tarde
                {
                    List<RestaurantePlato> asignaciones = new Conexion().FetchPlatoRestaurantesByIdRestaurante(idRestSeleccionado);

                    foreach (var asignacion in asignaciones)
                    {
                        listaIdsPlatos.Add(asignacion.IdPlato);
                    }

                    foreach (var idPlato in listaIdsPlatos)
                    {
                        Plato plato = new Conexion().FetchPlatoById(idPlato);
                        platos.Add(plato);
                    }

                    // Actualiza el datagrid con la lista de platos relacionados al restaurante
                    dataGridView_platos_disponibles.DataSource = platos.Where(x => x != null).ToList();
                }
            }
            else
            {
                var mensaje_errorReg = new FormMensaje("Ha ocurrido un error. Verifique los datos y vuelva a intentarlo");
                mensaje_errorReg.ShowDialog();
            }
        }

        private void button_anadir_platos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_platos_disponibles.SelectedRows)
            {
                if (row.DataBoundItem is Plato platoSeleccionado)
                {
                    platosElegidos.Add(platoSeleccionado);
                }
            }

            dataGridView_platos_elegidos.DataSource = platosElegidos.Where(x => x != null).ToList();

            if (platosElegidos.Count > 0)
            {

                HashSet<int> platosUnicos = new HashSet<int>();
                List<int> idsCategor�as = new List<int>();
                List<Extra> extrasDisponibles = new List<Extra>();

                foreach (Plato plato in platosElegidos)
                {
                    // Usa el HashSet para almacenar s�lo ids �nicos
                    if (platosUnicos.Add(plato.IdCategoria))
                    {
                        idsCategor�as.Add(plato.IdCategoria);
                    }
                }

                foreach (var id in idsCategor�as)
                {
                    List<Extra> extrasDeCategoria = new Conexion().FetchExtrasByIdCategoria(id);

                    foreach (var extra in extrasDeCategoria)
                    {
                        extrasDisponibles.Add(extra);
                    }
                }

                dataGridView_extras_disponibles.DataSource = extrasDisponibles.Where(x => x != null).ToList();
                button_hacer_pedido.Enabled = true;

                var mensaje_platosElegidos = new FormMensaje("El/los platos han sido a�adidos al pedido.");
                mensaje_platosElegidos.ShowDialog();
            }

            precioPlatos = 0;

            foreach (DataGridViewRow fila in dataGridView_platos_elegidos.Rows)
            {
                if (fila.DataBoundItem is Plato platoEnPedido)
                {

                    precioPlatos += platoEnPedido.Precio;
                }
            }

            precioTotal = 0;
            precioTotal = precioPlatos + precioExtras;

            label_precio_total.Text = "Costo del Pedido: " + precioTotal.ToString() + " colones";
        }

        private void button_anadir_extras_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_extras_disponibles.SelectedRows)
            {
                if (row.DataBoundItem is Extra extraSeleccionado)
                {
                    extrasElegidas.Add(extraSeleccionado);
                }
            }

            dataGridView_extras_elegidas.DataSource = extrasElegidas.Where(x => x != null).ToList();

            if (platosElegidos.Count > 0)
            {

                var mensaje_extrasElegidas = new FormMensaje("La(s) extras han sido a�adidas al pedido.");
                mensaje_extrasElegidas.ShowDialog();
            }

            precioExtras = 0;

            foreach (DataGridViewRow fila in dataGridView_extras_elegidas.Rows)
            {
                if (fila.DataBoundItem is Extra extraEnPedido)
                {

                    precioExtras += extraEnPedido.Precio;
                }
            }

            precioTotal = 0;
            precioTotal = precioPlatos + precioExtras;

            label_precio_total.Text = "Costo del Pedido: " + precioTotal.ToString() + " colones";
        }

        private void button_hacer_pedido_Click(object sender, EventArgs e)
        {
            try
            {
                bool pedidoExitoso = false;
                foreach (DataGridViewRow row in dataGridView_platos_elegidos.Rows)
                {
                    if (row.DataBoundItem is Plato platoSeleccionado)
                    {
                        Pedido nuevoPedido = new(clienteActivo.Id, platoSeleccionado.Id);
                        Conexion conexion = new Conexion();
                        var response = conexion.GenerarPedido(nuevoPedido);
                        if (response == false)
                        {
                            pedidoExitoso = false;
                        }
                        else
                        {
                            pedidoExitoso = true;
                            pedidosRealizados.Add(nuevoPedido);
                        }
                    }
                }

                foreach (Extra extra in extrasElegidas)
                {
                    Plato platoLigado = new("", 0, 0);
                    Pedido pedidoLigado = new(0, 0);

                    foreach (var plato in platosElegidos)
                    {
                        if (plato.IdCategoria == extra.IdCategoria)
                        {
                            platoLigado = plato;
                            break;
                        }
                    }

                    foreach (var pedido in pedidosRealizados)
                    {
                        if (pedido.IdPlato == platoLigado.Id)
                        {
                            pedidoLigado = pedido;
                            break;
                        }
                    }

                    PedidoExtra nuevoPedidoExtra = new(pedidoLigado.IdPedido, platoLigado.Id, extra.Id);
                    Conexion conexionExtra = new Conexion();
                    var responseExtra = conexionExtra.GenerarPedidoExtra(nuevoPedidoExtra);
                }

                if (pedidoExitoso == true)
                {
                    var mensaje_pedidoExitoso = new FormMensaje("Se ha realizado su orden");
                    mensaje_pedidoExitoso.ShowDialog();


                }
                else
                {
                    var mensaje_pedidoFallido = new FormMensaje("Ha ocurrido un error. Por favor int�ntelo de nuevo");
                    mensaje_pedidoFallido.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void button_consul_pedidos_Click(object sender, EventArgs e)
        {
            var historialPedidos = new FormHistorialPedidos(clienteActivo);
            historialPedidos.ShowDialog();
        }
    }
}
