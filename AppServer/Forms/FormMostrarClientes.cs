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
    public partial class FormMostrarClientes : Form
    {
        private ManagerClientes managerClientes;
        public FormMostrarClientes(ManagerClientes managerClientes)
        {
            this.managerClientes = managerClientes;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormMostrarClientes_Shown);
        }

        private void FormMostrarClientes_Shown(object sender, EventArgs e)
        {
            dataGridView_consul_clientes.DataSource = managerClientes.GetTodos().Where(x => x != null).ToList();
        }
    }
}
