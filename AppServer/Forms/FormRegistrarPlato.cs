using AppServidor.Forms;
using System;
using Libreria.Clases;
using Libreria.Managers;

namespace AppServidor.Forms
{
    public partial class FormRegistrarPlato : Form
    {
        private ManagerPlatos managerPlatos;
        private ManagerCategPlatos managerCategPlatos;
        public FormRegistrarPlato(ManagerPlatos managePlatos, ManagerCategPlatos managerCategPlatos)
        {
            InitializeComponent();
            this.managerPlatos = managePlatos;
            this.managerCategPlatos = managerCategPlatos;
        }

        private void button_reg_plato_Click(object sender, EventArgs e)
        {
            
            //Validación de los datos
            if (textBox_reg_plato_precio.Text == null || textBox_reg_plato_precio.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el precio del plato");
                mensaje.ShowDialog();
            }
            else if (textBox_reg_plato_idCateg.Text == null || textBox_reg_plato_idCateg.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el ID de la categoría");
                mensaje.ShowDialog();
            }
            else if (textBox_reg_plato_nombre.Text == null || textBox_reg_plato_nombre.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el nombre del plato");
                mensaje.ShowDialog();
            }
            else
            { 

                try
                {
                    string nombre = textBox_reg_plato_nombre.Text;
                    int precio = int.Parse(textBox_reg_plato_precio.Text);
                    int idCateg = int.Parse(textBox_reg_plato_idCateg.Text);
                    CategoriaPlato categ;

                    var validaCateg = managerCategPlatos.GetPorId(int.Parse(textBox_reg_plato_idCateg.Text));

                    if (validaCateg == null)
                    {
                        var mensaje = new FormMensaje("Error: El ID ingresado no corresponde a ninguna categoría");
                        mensaje.ShowDialog();
                    }
                    else
                    {
                        categ = managerCategPlatos.GetPorId(idCateg);
                        Plato nuevoPlato = new(nombre, precio, categ);

                        // Registra el plato
                        managerPlatos.Registrar(nuevoPlato);

                        var mensaje = new FormMensaje("El plato " + nombre + " ha sido añadido");
                        mensaje.ShowDialog();

                        textBox_reg_plato_nombre.Text = "";
                        textBox_reg_plato_precio.Text = "";
                        textBox_reg_plato_idCateg.Text = "";
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
