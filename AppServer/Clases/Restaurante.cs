using System.Net;
using System.Xml.Linq;

namespace Tarea2.Clases
{
    public class Restaurante
    {
        private static int SiguienteId = 1; // Compartida para todas las instancias
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
        public string Telefono { get; set; }


        // Constructor
        public Restaurante(string nombre, string direccion, bool activo, string telefono)
        {
            Id = SiguienteId;
            Nombre = nombre;
            Direccion = direccion;
            Activo = activo;
            Telefono = telefono;

            SiguienteId++;
        }

        public override string ToString()
        {
            return $"ID: {Id} | {Nombre} | {Direccion}";
        }
    }

}
