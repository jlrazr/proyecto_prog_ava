namespace AppCliente.Forms
{
    public partial class FormMensaje : Form
    {
        public FormMensaje(string mensaje)
        {
            InitializeComponent();
            Label_mensaje.Text = mensaje;
        }
    }
}
