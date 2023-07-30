using AppServidor.CapaDatos;
using Libreria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServidor.CapaNegocio
{
    public class ManagerPedido
    {
        CrudPedidos crudPedidos;
        public ManagerPedido()
        {
            this.crudPedidos = new();
        }

        public bool Registrar(Pedido pedido)
        {
            bool registroExitoso = false;

            try
            {
                registroExitoso = crudPedidos.CrearPedido(pedido);

                return registroExitoso;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return registroExitoso;
            }
        }

        public List<Pedido> GetPorIdCliente(int idCliente)
        {
            try
            {
                return crudPedidos.ObtenerPedidoPorIdCliente(idCliente);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Pedido GetPorId(int idPedido)
        {
            try
            {
                return crudPedidos.ObtenerPedidoPorId(idPedido);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Pedido> GetTodos()
        {
            return crudPedidos.ObtenerTodosPedidos();
        }
    }
}
