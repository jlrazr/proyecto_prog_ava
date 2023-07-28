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
        }

        Boolean logueado = false;
        private List<Restaurante> restaurantes;
        private List<Plato> platosElegidos = new();
        private List<Extra> extrasElegidas = new();
        private Cliente clienteActivo;


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
                        label_cliente.Text = "Cliente: " + clienteConectado.Nombre + " " + clienteConectado.PrimApellido + "\nID: " + clienteConectado.Id;
                        clienteActivo = clienteConectado;
                    }
                    else
                    {
                        label_cliente.Text = "Cliente: No existe un cliente con el ID ingresado";
                    }

                    logueado = !logueado;
                    button_cliente_login.Enabled = false;
                    button_cliente_logout.Enabled = false;
                    textBox_cliente_id_login.Enabled = false;
                    textBox_cliente_id_login.Text = "";
                    button_cliente_logout.Enabled = true;
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
            logueado = !logueado;
            button_cliente_login.Enabled = true;
            textBox_cliente_id_login.Enabled = true;
            button_cliente_logout.Enabled = false;
        }

        private void comboBox_lista_restaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_lista_restaurantes.SelectedItem != null && comboBox_lista_restaurantes.SelectedItem is Restaurante restauranteSeleccionado)
            {
                int idRestSeleccionado = restauranteSeleccionado.Id;
                List<Plato> platos = new();

                var restaurante = new Conexion().FetchRestauranteById(idRestSeleccionado);
                var listaIdsPlatos = new List<int>();
                if (restaurante != null) //Ojo que podría venir nulo y generar errores. Ver mas tarde
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

                    dataGridView_platos_elegidos.DataSource = platosElegidos.Where(x => x != null).ToList();
                }
            }

            var mensaje_platosElegidos = new FormMensaje("El/los platos han sido añadidos al pedido.");
            mensaje_platosElegidos.ShowDialog();
        }
    }
}
