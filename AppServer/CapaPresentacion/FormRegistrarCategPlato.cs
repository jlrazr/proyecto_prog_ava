﻿using AppServidor.Forms;
using Libreria.Clases;
using AppServidor.CapaNegocio;

namespace AppServidor.Forms
{
    public partial class FormRegistrarCategPlato : Form
    {
        private ManagerCategPlatos managerCategPlatos;
        public FormRegistrarCategPlato(ManagerCategPlatos managerCategorias)
        {
            InitializeComponent();
            this.managerCategPlatos = managerCategorias;
        }

        private void button_reg_cat_plato_Click(object sender, EventArgs e)
        {
            string descripcion = textBox_reg_cat_descripcion.Text;
            bool estado = checkBox_reg_cat_activa.Checked;

            //Validación de los datos
            if (descripcion == null || descripcion == "")
            {
                var mensaje = new FormMensaje("Error: Verifique la descripción de la categoría");
                mensaje.ShowDialog();
            }
            else
            {
                CategoriaPlato nuevaCategoria = new(descripcion, estado);

                // Registra la categoría
                managerCategPlatos.Registrar(nuevaCategoria);

                var mensaje = new FormMensaje("La categoría " + descripcion + " ha sido añadida");
                mensaje.ShowDialog();

                textBox_reg_cat_descripcion.Text = "";
                checkBox_reg_cat_activa.Checked = false;
            }
        }
    }
}
