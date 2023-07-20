using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.Managers;

namespace AppServer.Forms
{
    public partial class FormMostrarCategPlatos : Form
    {
        private ManagerCategPlatos managerCateg;
        public FormMostrarCategPlatos(ManagerCategPlatos managerCateg)
        {
            InitializeComponent();
            this.managerCateg = managerCateg;
            this.Shown += new System.EventHandler(this.FormMostrarCategPlatos_Shown);
        }

        private void FormMostrarCategPlatos_Shown(object sender, EventArgs e)
        {
            dataGridView_consul_categ.DataSource = managerCateg.GetTodos().Where(x => x != null).ToList();
        }
    }
}
