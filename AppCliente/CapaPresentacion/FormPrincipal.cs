using AppCliente.Forms;
using Libreria.Clases;
using Newtonsoft.Json;
using System.Diagnostics;

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

                    Cliente clienteConectado = new(response.Cliente.Nombre, response.Cliente.PrimApellido, response.Cliente.SegApellido, response.Cliente.FechaNacimiento, response.Cliente.Genero);
                    clienteConectado.Id = response.Cliente.Id;

                    if (response.Existe)
                    {
                        label_cliente.Text = "Cliente: " + clienteConectado.Nombre + " " + clienteConectado.PrimApellido + "\nID: " + clienteConectado.Id;
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
    }
}
