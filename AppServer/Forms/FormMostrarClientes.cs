using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.Clases;
using Libreria.ClasesDB;
using Libreria.Managers;

namespace AppServidor.Forms
{
    public partial class FormMostrarClientes : Form
    {
        //private ManagerClientes managerClientes;
        private ClienteCRUD ClienteCRUD;
        public FormMostrarClientes(ClienteCRUD _ClienteCRUD)
        {
            this.ClienteCRUD = _ClienteCRUD;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormMostrarClientes_Shown);
        }

        private void FormMostrarClientes_Shown(object sender, EventArgs e)
        {
            List<Cliente> clientes = ClienteCRUD.ObtenerTodosCliente();
            dataGridView_consul_clientes.DataSource = clientes.Where(x => x != null).ToList();
        }
    }
}
