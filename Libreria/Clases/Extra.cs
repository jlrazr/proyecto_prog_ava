using System.ComponentModel.DataAnnotations;
using System;

namespace Libreria.Clases
{
    public class Extra
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public int IdCategoria { get; set; }
        public bool Estado { get; set; }
        public int Precio { get; set; }


        // Constructor
        public Extra(string descripcion, int categoriaPlato, bool activo, int precio)
        {
            Descripcion = descripcion;
            IdCategoria = categoriaPlato;
            Estado = activo;
            Precio = precio;
        }
    }
}


