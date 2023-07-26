using System.ComponentModel.DataAnnotations;
using System;

namespace Libreria.Clases
{
    public class RestaurantePlato
    {
        public int Id { get; set; }

        public int IdPlato { get; set; }

        public int IdRestaurante { get; set; }

        public DateTime FechaAsignacion { get; set; }


        // Constructor
        public RestaurantePlato(int rest, int platos)
        {
            Id = GeneradorIds.GenerarID();
            IdPlato = platos;
            IdRestaurante = rest;
            FechaAsignacion = DateTime.Now;
        }
    }
}
