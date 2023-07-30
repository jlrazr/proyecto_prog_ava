using System.ComponentModel.DataAnnotations;
using System;

namespace Libreria.Clases
{
    public class PedidoExtra
    {
        public int IdPedido { get; set; }
        public int IdPlato { get; set; }
        public int IdExtra { get; set; }

        // Constructor
        public PedidoExtra(int idPedido, int idPlato, int idExtra)
        {
            IdPedido = idPedido;
            IdPlato = idPlato;
            IdExtra = idExtra;
        }
    }
}