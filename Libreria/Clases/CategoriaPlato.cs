namespace Libreria.Clases
{
    public class CategoriaPlato
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        // Constructor
        public CategoriaPlato(string descripcion, bool estado)
        {
            Descripcion = descripcion;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"ID: {Id} | {Descripcion}";
        }
    }
}

