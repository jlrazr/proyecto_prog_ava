namespace Libreria.Clases
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimApellido { get; set; }
        public string SegApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Genero { get; set; }

        // Constructor
        public Cliente(string nombre, string primApellido, string segApellido, DateTime fechaNacimiento, char genero)
        {
            Nombre = nombre;
            PrimApellido = primApellido;
            SegApellido = segApellido;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
        }
    }

}
