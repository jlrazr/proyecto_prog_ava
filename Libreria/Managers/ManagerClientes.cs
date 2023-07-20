using System.Xml.Linq;
using Libreria.Clases;

namespace Libreria.Managers
{
    public class ManagerClientes : IManager<Cliente>
    {
        private Cliente[] _clientes = new Cliente[20];
        private int _cuentaClientes = 0;

        public void Registrar(Cliente cliente)
        {
            if (_cuentaClientes < 20)
            {
                _clientes[_cuentaClientes++] = cliente;
            }
        }

        public Cliente[] GetTodos()
        {
            return _clientes;
        }
    }
}
