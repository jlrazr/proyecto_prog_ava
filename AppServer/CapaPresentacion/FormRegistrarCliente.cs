using Libreria.Clases;
using AppServidor.CapaNegocio;
using AppServidor.CapaDatos;

namespace AppServidor.Forms
{
    public partial class FormRegistrarCliente : Form
    {
        private ManagerClientes managerClientes;

        public FormRegistrarCliente(ManagerClientes managerClientes)
        {
            InitializeComponent();
            this.managerClientes = managerClientes;
        }

        private void button_reg_cliente_Click(object sender, EventArgs e)
        {
            string nombre = textBox_reg_cliente_nombre.Text;
            string primApellido = textBox_reg_cliente_apellido1.Text;
            string segApellido = textBox_reg_cliente_apellido2.Text;
            DateTime fechaNacim = dateTimePicker_reg_cliente_dob.Value;
            char genero = 'n';

            if (radioButton_reg_cliente_m.Checked)
            {
                genero = 'm';
            }
            else if (radioButton_reg_cliente_f.Checked)
            {
                genero = 'f';
            }

            //Validación de los datos
            if (nombre == null || nombre == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el nombre del cliente");
                mensaje.ShowDialog();
            }
            else if (primApellido == null || primApellido == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el primer apellido del cliente");
                mensaje.ShowDialog();
            }
            else if (segApellido == null || segApellido == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el segundo apellido del cliente");
                mensaje.ShowDialog();
            }
            else if (genero == 'n')
            {
                var mensaje = new FormMensaje("Error: Debe elegir un género");
                mensaje.ShowDialog();
            }
            else
            {
                Cliente nuevoCliente = new(nombre, primApellido, segApellido, fechaNacim, genero);

                // Registra el cliente
                managerClientes.Registrar(nuevoCliente);

                var mensaje = new FormMensaje("El cliente " + nombre + " " + primApellido + " ha sido añadido");
                mensaje.ShowDialog();

                textBox_reg_cliente_nombre.Text = "";
                textBox_reg_cliente_apellido1.Text = "";
                textBox_reg_cliente_apellido2.Text = "";
                radioButton_reg_cliente_m.Checked = false;
                radioButton_reg_cliente_f.Checked = false;
            }
        }
    }
}
