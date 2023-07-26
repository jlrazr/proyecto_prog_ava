using Libreria.Clases;
using AppServidor.Forms;
using AppServidor.CapaNegocio;

namespace AppServidor
{
    public partial class FormRegistrarRestaurante : Form
    {
        private ManagerRestaurantes managerRest;
        public FormRegistrarRestaurante(ManagerRestaurantes managerRestaurantes)
        {
            InitializeComponent();
            this.managerRest = managerRestaurantes;
        }

        private void button_reg_restaurante_Click(object sender, EventArgs e)
        {
            string nombre = textBox_reg_rest_nombre.Text;
            string direccion = textBox_reg_rest_direccion.Text;
            bool activo = checkBox__reg_rest_activo.Checked;
            string telefono = textBox_reg_rest_telefono.Text;

            //Validación de los datos
            if(nombre == null || nombre == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el nombre del restaurante");
                mensaje.ShowDialog();
            } else if (direccion == null || direccion == "")
            {
                var mensaje = new FormMensaje("Error: Verifique la dirección del restaurante");
                mensaje.ShowDialog();
            } else if (telefono == null || telefono == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el teléfono del restaurante");
                mensaje.ShowDialog();
            } else
            {
                Restaurante nuevoRest = new(nombre, direccion, activo, telefono);


                // Registra el restaurante
                managerRest.Registrar(nuevoRest);

                var mensaje = new FormMensaje("El restaurante " + nombre + " ha sido añadido");
                mensaje.ShowDialog();

                textBox_reg_rest_nombre.Text = "";
                textBox_reg_rest_direccion.Text = "";
                checkBox__reg_rest_activo.Checked = false;
                textBox_reg_rest_telefono.Text = "";
            }
        }
    }
}
