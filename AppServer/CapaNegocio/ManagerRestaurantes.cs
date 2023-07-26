using AppServidor.CapaDatos;
using Libreria.Clases;

namespace AppServidor.CapaNegocio
{
    public class ManagerRestaurantes
    {
        CrudRestaurantes crudRestaurantes;
        public ManagerRestaurantes()
        {
            this.crudRestaurantes = new();
        }

        public bool Registrar(Restaurante restaurante)
        {
            bool registroExitoso = false;

            try
            {
                registroExitoso = crudRestaurantes.CrearRestaurante(restaurante);

                return registroExitoso;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return registroExitoso;
            }
        }

        public List<Restaurante> GetTodos()
        {
            return crudRestaurantes.ObtenerTodosRestaurantes();
        }

        public Restaurante GetPorId(int id)
        {
            try
            {
                return crudRestaurantes.ObtenerRestaurantePorId(id);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
