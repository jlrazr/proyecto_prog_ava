using System.Data;
using Libreria.Clases;
using Libreria.Managers;

namespace AppServidor.Forms
{
    public partial class FormRegistrarPlatoRestaurante : Form
    {
        private ManagerPlatos managerPlatos;
        private ManagerRestaurantePlatos managerRestaurantePlatos;
        private ManagerRestaurantes managerRestaurantes;

        public FormRegistrarPlatoRestaurante(ManagerPlatos managerPlatos, ManagerRestaurantePlatos managerRestaurantePlatos, ManagerRestaurantes managerRestaurantes)
        {
            this.managerPlatos = managerPlatos;
            this.managerRestaurantePlatos = managerRestaurantePlatos;
            this.managerRestaurantes = managerRestaurantes;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormRegistrarPlatoRestaurante_Shown);
        }

        private void FormRegistrarPlatoRestaurante_Shown(object sender, EventArgs e)
        {
            comboBox_reg_platoRest_lista.DataSource = managerRestaurantes.GetTodos().Where(x => x != null && x.Estado == true).ToList();
            dataGridView_reg_platoRrest.DataSource = managerPlatos.GetTodos().Where(x => x != null).ToList();
            comboBox_reg_platoRest_lista.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_reg_platoRest_Click(object sender, EventArgs e)
        {
            if (comboBox_reg_platoRest_lista.SelectedItem != null && comboBox_reg_platoRest_lista.SelectedItem is Restaurante restauranteSeleccionado)
            {
                int idRestSeleccionado = restauranteSeleccionado.Id;

                if (managerRestaurantes.GetPorId(idRestSeleccionado) != null)
                {
                    foreach (DataGridViewRow row in dataGridView_reg_platoRrest.SelectedRows)
                    {
                        if (row.DataBoundItem is Plato platoSeleccionado)
                        {
                            int idPlatoSeleccionado = platoSeleccionado.Id;

                            RestaurantePlato restPlato = new(idRestSeleccionado, idPlatoSeleccionado);
                            managerRestaurantePlatos.Registrar(restPlato);
                        }
                    }

                    var mensaje_platosNoRegistrados = new FormMensaje("El/los platos han sido registrados en el restaurante " + restauranteSeleccionado.Nombre);
                    mensaje_platosNoRegistrados.ShowDialog();
                }
            }
            else
            {
                var mensaje_errorReg = new FormMensaje("Ha ocurrido un error. Verifique los datos y vuelva a intentarlo");
                mensaje_errorReg.ShowDialog();
            }
        }

        private void button_consul_platosRest_Click(object sender, EventArgs e)
        {
            //if (comboBox_reg_platoRest_lista.SelectedItem != null && comboBox_reg_platoRest_lista.SelectedItem is Restaurante restauranteSeleccionado)
            //{
            //    int idRestSeleccionado = restauranteSeleccionado.Id;
            //    RestaurantePlato? restPlato = managerRestaurantePlatos.GetPorIdRestaurante(idRestSeleccionado);
            //
             //   dataGridView_consul_platosRest.DataSource = restPlato?.Platos.Where(x => x != null).ToList();
            //    label_fecha_afil.Text = "Fecha de afiliación: " + restPlato?.FechaAfiliacion.ToString();
            //}
            //else
            //{
            //    var mensaje_errorConsul = new FormMensaje("Ha ocurrido un error. Verifique que el restaurante tenga platos registrados y vuelva a intentarlo");
            //    mensaje_errorConsul.ShowDialog();
            //}
        }
    }
}


