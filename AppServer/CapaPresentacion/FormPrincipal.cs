using AppServidor.Forms;
using AppServidor.CapaNegocio;
using System.Diagnostics;

namespace AppServidor
{
    public partial class FormPrincipal : Form
    {
        private ManagerRestaurantes managerRest = new();
        private ManagerPlatos managerPlatos = new();
        private ManagerCategPlatos managerCategPlatos = new();
        private ManagerClientes managerClientes = new();
        private ManagerRestaurantePlatos managerRestPlatos = new();
        private ManagerExtra managerExtra = new();

        private bool servidorIniciado = false;
        static Servidor servidor = new Servidor(14100);
        Thread hiloServidor = new Thread(new ThreadStart(servidor.Start));

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button_menu_reg_restaurante_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarRestaurante(managerRest);
            form.ShowDialog();
        }

        private void button_reg_catPlatos_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarCategPlato(managerCategPlatos);
            form.ShowDialog();
        }

        private void button_reg_plato_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarPlato(managerPlatos, managerCategPlatos);
            form.ShowDialog();
        }

        private void button_reg_cliente_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarCliente(managerClientes);
            form.ShowDialog();
        }

        private void button_reg_platoRest_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarPlatoRestaurante(managerPlatos, managerRestPlatos, managerRest);
            form.ShowDialog();
        }

        private void button_reg_extras_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarExtra(managerExtra, managerCategPlatos);
            form.ShowDialog();
        }

        private void button_consul_rest_Click(object sender, EventArgs e)
        {
            var form = new FormMostrarRestaurantes(managerRest);
            form.ShowDialog();
        }

        private void button_consul_clientes_Click(object sender, EventArgs e)
        {
            var form = new FormMostrarClientes(managerClientes);
            form.ShowDialog();
        }

        private void button_consul_categ_Click(object sender, EventArgs e)
        {
            var form = new FormMostrarCategPlatos(managerCategPlatos);
            form.ShowDialog();
        }

        private void button_consul_platos_Click(object sender, EventArgs e)
        {
            var form = new FormMostrarPlatos(managerPlatos);
            form.ShowDialog();
        }

        private void button_consul_extras_Click(object sender, EventArgs e)
        {
            var form = new FormMostrarExtras(managerExtra);
            form.ShowDialog();
        }

        private void button_consul_plato_rest_Click(object sender, EventArgs e)
        {
            var form = new FormMostrarPlatoRestaurante(managerPlatos, managerRestPlatos, managerRest);
            form.ShowDialog();
        }

        private void button_servidor_iniciar_Click(object sender, EventArgs e)
        {
            if (servidorIniciado == false)
            {
                try
                {
                    hiloServidor.Start();
                    label_estado_servidor.Text = "Servidor iniciado en el puerto 14100";
                    servidorIniciado = !servidorIniciado;
                } catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                
            }
        }

        private void button_servidor_detener_Click(object sender, EventArgs e)
        {
            servidor.Stop();


            if (hiloServidor.IsAlive)
            {
                Debug.WriteLine("aca jode el hp");
                hiloServidor.Join();
            }
            

            servidorIniciado = false;
            label_estado_servidor.Text = "Servidor detenido";
            
        }
    }
}
