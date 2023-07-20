using System.ComponentModel.DataAnnotations;
using System;

namespace Tarea2.Clases
{
    public class Extra
    {
        private static int SiguienteId = 1; // Compartida para todas las instancias 

        public int ID { get; private set; }
        public string Descripcion { get; set; }

        public CategoriaPlato CategoriaPlato { get; set; }
        public bool Activo { get; set; }
        public int Precio { get; set; }


        // Constructor
        public Extra(string descripcion, CategoriaPlato categoriaPlato, bool activo, int precio)
        {
            ID = SiguienteId;
            Descripcion = descripcion;
            CategoriaPlato = categoriaPlato;
            Activo = activo;
            Precio = precio;

            SiguienteId++;
        }
    }
}


