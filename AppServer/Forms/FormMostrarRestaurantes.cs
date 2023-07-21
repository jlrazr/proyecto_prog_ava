using System.ComponentModel;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Libreria.Managers;

namespace AppServidor.Forms
{
    public partial class FormMostrarRestaurantes : Form
    {
        private ManagerRestaurantes managerRest;
        public FormMostrarRestaurantes(ManagerRestaurantes managerRest)
        {
            this.managerRest = managerRest;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormMostrarRestaurantes_Shown);

        }

        private void FormMostrarRestaurantes_Shown(object sender, EventArgs e)
        {
            dataGridView_consul_restaruantes.DataSource = managerRest.GetTodos().Where(x => x != null).ToList();
        }
    }
}
