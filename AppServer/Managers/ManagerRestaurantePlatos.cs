using System.Xml.Linq;
using Tarea2.Clases;

namespace Tarea2.Managers
{
    public class ManagerRestaurantePlatos : IManager<RestaurantePlato>
    {
        private RestaurantePlato[] _restaurantePlatos = new RestaurantePlato[20];
        private int _cuentaRestaurantePlatos = 0;
        public int _numeroPlatos = 0;

        public void Registrar(RestaurantePlato restaurantePlato)
        {
            if (_cuentaRestaurantePlatos < 10)
            {
                _restaurantePlatos[_cuentaRestaurantePlatos++] = restaurantePlato;
            }
            else
            {
                Console.WriteLine("El número máximo de platos (10) ya se ha alcanzado.");
            }
        }
        public RestaurantePlato[] GetTodos()
        {
            return _restaurantePlatos;
        }

        public RestaurantePlato? GetPorIdRestaurante(int id)
        {
            for (int i = 0; i < _cuentaRestaurantePlatos; i++)
            {
                if (_restaurantePlatos[i].Restaurante.Id == id)
                {
                    return _restaurantePlatos[i];
                }
            }
            return null;
        }

        public bool ExisteRestaurante(int id)
        {
            for (int i = 0; i < _cuentaRestaurantePlatos; i++)
            {
                if (_restaurantePlatos[i].Restaurante.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void AnadirPlatos(int idRest, Plato plato)
        {
            for (int i = 0; i < _cuentaRestaurantePlatos; i++)
            {
                if (_restaurantePlatos[i].Restaurante.Id == idRest)
                {
                    _restaurantePlatos[i].Platos[_numeroPlatos] = plato;
                    _numeroPlatos++;
                }
            }
        }

        public void LimpiarPlatos(int id)
        {
            for (int i = 0; i < _cuentaRestaurantePlatos; i++)
            {
                if (_restaurantePlatos[i].Restaurante.Id == id)
                {
                    _restaurantePlatos[i].Platos = new Plato[10];
                }
            }

            _numeroPlatos = 0;
        }
    }
}
