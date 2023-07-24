using Libreria.AccesoBD;
using Libreria.Clases;

namespace Libreria.Managers
{
    public class ManagerRestaurantePlatos
    {
        CrudRestaurantePlatos crudRestaurantePlatos;

        public ManagerRestaurantePlatos()
        {
            this.crudRestaurantePlatos = new();
        }

        public bool Registrar(RestaurantePlato restPlato)
        {
            bool registroExitoso = false;

            try
            {
                registroExitoso = crudRestaurantePlatos.CrearRestaurantePlato(restPlato);

                return registroExitoso;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return registroExitoso;
            }
        }

        public List<RestaurantePlato> GetPorIdRestaurante(int id)
        {
            return crudRestaurantePlatos.ObtenerRestPlatoPorIdRestaurante(id);
        }
    }
}
