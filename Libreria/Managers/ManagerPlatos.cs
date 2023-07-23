using Libreria.AccesoBD;
using Libreria.Clases;

namespace Libreria.Managers
{
    public class ManagerPlatos
    {
        CrudPlatos crudPlatos;

        public ManagerPlatos()
        {
            this.crudPlatos = new();
        }

        public bool Registrar(Plato plato)
        {
            bool registroExitoso = false;

            try
            {
                registroExitoso = crudPlatos.CrearPlato(plato);

                return registroExitoso;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return registroExitoso;
            }
        }

        public List<Plato> GetTodos()
        {
            return crudPlatos.ObtenerTodosPlato();
        }

        public Plato GetPorId(int id)
        {
            return null;
        }
    }
}
