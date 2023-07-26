using AppServidor.CapaDatos;
using Libreria.Clases;

namespace AppServidor.CapaNegocio
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

        public List<int> GetIdPlatosPorIdRestaurante(int id)
        {
            List<RestaurantePlato> listaAsignaciones = GetPorIdRestaurante(id);
            List<int> idsPlatos = new List<int>();

            foreach (var item in listaAsignaciones)
            {
                idsPlatos.Add(item.IdPlato);
            }

            return idsPlatos;
        }
    }
}
