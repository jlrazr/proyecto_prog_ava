using System.Xml.Linq;
using Libreria.AccesoBD;
using Libreria.Clases;

namespace Libreria.Managers
{
    public class ManagerClientes
    {
        CrudClientes crudClientes;
        public ManagerClientes() {
            this.crudClientes = new();
        }
        public bool Registrar(Cliente cliente)
        {
            bool registroExitoso = false;

            try
            {
                registroExitoso = crudClientes.CrearCliente(cliente);

                return registroExitoso;
            } catch (Exception ex)
            {
                return registroExitoso;
            } 
        }

        public List<Cliente> GetTodos()
        {
            return crudClientes.ObtenerTodosCliente();
        }
    }
}
