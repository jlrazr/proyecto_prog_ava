using System.ComponentModel.DataAnnotations;
using System;

namespace Tarea2.Clases
{
    public class RestaurantePlato
    {
        private static int SiguienteId = 1; // Compartida para todas las instancias

        public Plato[] Platos { get; set; }
        public Restaurante Restaurante { get; set; }
        public DateTime FechaAfiliacion { get; set; }


        // Constructor
        public RestaurantePlato(Restaurante rest, Plato[] platos)
        {
            Platos = platos;
            Restaurante = rest;
            FechaAfiliacion = DateTime.Now;

            SiguienteId++;
        }
    }
}
