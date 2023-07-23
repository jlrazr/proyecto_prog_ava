using Libreria.AccesoBD;
using Libreria.Clases;

namespace Libreria.Managers
{
    public class ManagerCategPlatos
    {
        CrudCategPlatos crudCategPlatos;

        public ManagerCategPlatos()
        {
            this.crudCategPlatos = new();
        }
        public bool Registrar(CategoriaPlato categoriaPlato)
        {
            bool registroExitoso = false;

            try
            {
                registroExitoso = crudCategPlatos.CrearCategoria(categoriaPlato);

                return registroExitoso;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return registroExitoso;
            }
        }

        public List<CategoriaPlato> GetTodos()
        {
            try
            {
                return crudCategPlatos.ObtenerTodasCategPlato();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public CategoriaPlato GetPorId(int id)
        {
            try
            {
                return crudCategPlatos.ObtenerCategPlatoPorId(id);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
