using Libreria.Clases;
using AppServidor.CapaNegocio;
using System.Data;

namespace AppServidor.Forms
{
    public partial class FormMostrarPlatoRestaurante : Form
    {
        private ManagerPlatos managerPlatos;
        private ManagerRestaurantePlatos managerRestaurantePlatos;
        private ManagerRestaurantes managerRestaurantes;

        public FormMostrarPlatoRestaurante(ManagerPlatos managerPlatos, ManagerRestaurantePlatos managerRestaurantePlatos, ManagerRestaurantes managerRestaurantes)
        {
            this.managerPlatos = managerPlatos;
            this.managerRestaurantePlatos = managerRestaurantePlatos;
            this.managerRestaurantes = managerRestaurantes;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormMostrarPlatoRestaurante_Shown);
        }

        private void FormMostrarPlatoRestaurante_Shown(object sender, EventArgs e)
        {
            comboBox_consul_restaurantes.DataSource = managerRestaurantes.GetTodos().Where(x => x != null && x.Estado == true).ToList();
            comboBox_consul_restaurantes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox_consul_restaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_consul_restaurantes.SelectedItem != null && comboBox_consul_restaurantes.SelectedItem is Restaurante restauranteSeleccionado)
            {
                int idRestSeleccionado = restauranteSeleccionado.Id;

                if (managerRestaurantes.GetPorId(idRestSeleccionado) != null)
                {
                    List<int> listaIdsPlatos = managerRestaurantePlatos.GetIdPlatosPorIdRestaurante(idRestSeleccionado);
                    List<Plato> platosAsignados = new();

                    for (int i = 0; i < listaIdsPlatos.Count; i++)
                    {
                        platosAsignados.Add(managerPlatos.GetPorId(listaIdsPlatos[i]));
                    }

                    dataGridView_consul_PlatoRest.DataSource = platosAsignados.Where(x => x != null).ToList();
                }
            }
            else
            {
                var mensaje_errorReg = new FormMensaje("Ha ocurrido un error. Verifique los datos y vuelva a intentarlo");
                mensaje_errorReg.ShowDialog();
            }
        }
    }
}
