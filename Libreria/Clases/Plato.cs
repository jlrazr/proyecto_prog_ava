using System.ComponentModel.DataAnnotations;
using System;

namespace Libreria.Clases
{
    public class Plato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
        public int Precio { get; set; }
        

        // Constructor
        public Plato(string nombre, int idCategoria, int precio)
        {
            Id = GeneradorIds.GenerarID();
            Nombre = nombre;
            IdCategoria = idCategoria;
            Precio = precio;
        }
    }
}
