using System;
using AppServer.Forms;
using Libreria.Clases;
using Libreria.Managers;

namespace AppServer.Forms
{
    public partial class FormRegistrarExtra : Form
    {
        private ManagerExtra managerExtra;
        private ManagerCategPlatos managerCategPlatos;
        public FormRegistrarExtra(ManagerExtra managerExtra, ManagerCategPlatos managerCategPlatos)
        {
            InitializeComponent();
            this.managerExtra = managerExtra;
            this.managerCategPlatos = managerCategPlatos;
        }

        private void button_reg_extras_Click(object sender, EventArgs e)
        {
            //Validación de los datos
            if (textBox_reg_extra_desc.Text == null || textBox_reg_extra_desc.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique la descripción de la extra");
                mensaje.ShowDialog();
            }
            else if (textBox_reg_extra_idCateg.Text == null || textBox_reg_extra_idCateg.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el ID de la categoría");
                mensaje.ShowDialog();
            }
            else if (textBox_reg_extra_precio.Text == null || textBox_reg_extra_precio.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el precio de la extra");
                mensaje.ShowDialog();
            }
            else
            {
                try
                {
                    string descripcion = textBox_reg_extra_desc.Text;
                    int idCateg = int.Parse(textBox_reg_extra_idCateg.Text);
                    int precio = int.Parse(textBox_reg_extra_precio.Text);
                    bool activa = checkBox_reg_extra_activa.Checked;
                    CategoriaPlato categ;

                    var validaCateg = managerCategPlatos.GetPorId(int.Parse(textBox_reg_extra_idCateg.Text));

                    if (validaCateg == null)
                    {
                        var mensaje = new FormMensaje("Error: El ID ingresado no corresponde a ninguna categoría");
                        mensaje.ShowDialog();
                    }
                    else
                    {
                        categ = managerCategPlatos.GetPorId(idCateg);
                        Extra nuevaExtra = new(descripcion, categ, activa, precio);

                        // Registra la extra
                        managerExtra.RegistrarExtra(nuevaExtra);

                        var mensaje = new FormMensaje("La extra " + descripcion + " ha sido añadida");
                        mensaje.ShowDialog();

                        textBox_reg_extra_desc.Text = "";
                        textBox_reg_extra_precio.Text = "";
                        textBox_reg_extra_idCateg.Text = "";
                        checkBox_reg_extra_activa.Checked = false;
                    }
                }
                catch
                {
                    var mensaje = new FormMensaje("Ha ocurrido un error. Por favor verifique los datos ingresados y vuelva a intentarlo.");
                    mensaje.ShowDialog();
                }
            }
        }
    }
}
