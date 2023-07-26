using System.ComponentModel.DataAnnotations;
using System;

namespace Libreria.Clases
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdPlato { get; set; }
        public DateTime FechaPedido { get; set; }


        // Constructor
        public Pedido(int idCliente, int idPlato)
        {
            IdPedido = GeneradorIds.GenerarID();
            IdCliente = idCliente;
            IdPlato = idPlato;
            FechaPedido = DateTime.Now;
        }
    }
}