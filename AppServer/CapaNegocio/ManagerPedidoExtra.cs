using AppServidor.CapaDatos;
using Libreria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServidor.CapaNegocio
{
    public class ManagerPedidoExtra
    {
        CrudPedidosExtra crudPedidoExtra;
        public ManagerPedidoExtra()
        {
            this.crudPedidoExtra = new();
        }

        public bool Registrar(PedidoExtra pedidoExtra)
        {
            bool registroExitoso = false;

            try
            {
                registroExitoso = crudPedidoExtra.CrearPedidoExtra(pedidoExtra);

                return registroExitoso;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return registroExitoso;
            }
        }

        public List<PedidoExtra> GetPorIdPedido(int idPedido)
        {
            try
            {
                return crudPedidoExtra.ObtenerPorIdPedido(idPedido);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
