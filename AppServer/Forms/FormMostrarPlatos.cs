using System.Data;
using Libreria.Clases;
using Libreria.Managers;

namespace AppServidor.Forms
{
    public partial class FormMostrarPlatos : Form
    {
        private ManagerPlatos managerPlatos;
        public FormMostrarPlatos(ManagerPlatos managerPlatos)
        {
            this.managerPlatos = managerPlatos;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormMostrarPlatos_Shown);
        }

        private void FormMostrarPlatos_Shown(object sender, EventArgs e)
        {
            List<Plato> platos = managerPlatos.GetTodos();
            dataGridView_consul_platos.DataSource = platos.Where(x => x != null).ToList();
        }
    }
}
