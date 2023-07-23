using System.Data;
using Libreria.Clases;
using Libreria.AccesoBD;
using Libreria.Managers;

namespace AppServidor.Forms
{
    public partial class FormMostrarClientes : Form
    {
        private ManagerClientes managerClientes;
        //private CrudClientes ClienteCRUD;
        public FormMostrarClientes(ManagerClientes managerClientes)
        {
            this.managerClientes = managerClientes;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormMostrarClientes_Shown);
        }

        private void FormMostrarClientes_Shown(object sender, EventArgs e)
        {
            List<Cliente> clientes = managerClientes.GetTodos();
            dataGridView_consul_clientes.DataSource = clientes.Where(x => x != null).ToList();
        }
    }
}
