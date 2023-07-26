using System.Data;
using Libreria.Clases;
using AppServidor.CapaNegocio;

namespace AppServidor.Forms
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
            List<CategoriaPlato> categorias = managerCateg.GetTodos();
            dataGridView_consul_categ.DataSource = categorias.Where(x => x != null).ToList();
        }
    }
}
