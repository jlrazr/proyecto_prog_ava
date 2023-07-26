using System.ComponentModel.DataAnnotations;
using System;

namespace Libreria.Clases
{
    public class PedidoExtra
    {
        public int IdPedido { get; set; }
        public int IdPlato { get; set; }
        public int IdExtra { get; set; }
        public DateTime FechaPedido { get; set; }


        // Constructor
        public PedidoExtra(int idPlato, int idExtra)
        {
            IdPedido = GeneradorIds.GenerarID();
            IdPlato = idPlato;
            IdExtra = idExtra;
        }
    }
}