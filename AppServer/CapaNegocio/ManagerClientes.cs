using AppServidor.CapaDatos;
using Libreria.Clases;
using System.Diagnostics;

namespace AppServidor.CapaNegocio
{
    public class ManagerClientes
    {
        CrudClientes crudClientes;
        public ManagerClientes()
        {
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
                System.Console.WriteLine(ex.Message);
                return registroExitoso;
            } 
        }

        public List<Cliente> GetTodos()
        {
            return crudClientes.ObtenerTodosCliente();
        }

        public Cliente GetClientePorId(int id)
        {
            try
            {
                return crudClientes.ObtenerClientePorId(id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
            


    }
}
