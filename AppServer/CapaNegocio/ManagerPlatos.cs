using AppServidor.CapaDatos;
using Libreria.Clases;

namespace AppServidor.CapaNegocio
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
            try
            {
                return crudPlatos.ObtenerPlatoPorId(id);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
