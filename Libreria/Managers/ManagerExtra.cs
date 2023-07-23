using System.Xml.Linq;
using Libreria.AccesoBD;
using Libreria.Clases;

namespace Libreria.Managers
{
    public class ManagerExtra
    {
        CrudExtras crudExtra;

        public ManagerExtra()
        {
            this.crudExtra = new();
        }

        public bool Registrar(Extra extra)
        {
            bool registroExitoso = false;

            try
            {
                registroExitoso = crudExtra.CrearExtra(extra);

                return registroExitoso;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return registroExitoso;
            }
        }

        public List<Extra> GetTodos()
        {
            try
            {
                return crudExtra.ObtenerTodosExtra();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Extra GetPorId(int id)
        {
            try
            {
                return crudExtra.ObtenerExtraPorId(id);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
