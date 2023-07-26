using AppCliente.Forms;
using System.Diagnostics;

namespace AppCliente
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            button_cliente_logout.Visible = false;
        }

        Boolean logueado = false;

        private void button_cliente_login_Click(object sender, EventArgs e)
        {

            //Verifica que el ID exista y que el input no sea null
            try
            {
                int idIngresado = int.Parse(textBox_cliente_id_login.Text);

                if (idIngresado == null)
                {
                    var mensaje_errorReg = new FormMensaje("Ha ocurrido un error. Verifique los datos y vuelva a intentarlo");
                    mensaje_errorReg.ShowDialog();
                }
                else
                {
                    logueado = !logueado;
                    groupBox_login.Visible = !logueado;
                    button_cliente_logout.Visible = logueado;
                    textBox_cliente_id_login.Text = "";
                }
            }
            catch (Exception ex)
            {
                var mensaje_errorReg = new FormMensaje("Ha ocurrido un error: " + ex.Message);
                mensaje_errorReg.ShowDialog();
            }
        }

        private void button_cliente_logout_Click(object sender, EventArgs e)
        {
            logueado = !logueado;
            groupBox_login.Visible = !logueado;
            button_cliente_logout.Visible = logueado;
        }
    }
}
