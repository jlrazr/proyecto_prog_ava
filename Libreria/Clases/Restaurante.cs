namespace Libreria.Clases
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }
        public string Telefono { get; set; }


        // Constructor
        public Restaurante(string nombre, string direccion, bool estado, string telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Estado = estado;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"ID: {Id} | {Nombre} | {Direccion}";
        }
    }

}
