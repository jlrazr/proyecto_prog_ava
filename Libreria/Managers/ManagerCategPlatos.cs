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
            return crudCategPlatos.ObtenerTodasCategPlato();
        }

        public CategoriaPlato GetPorId(int id)
        {
            //foreach (var categ in _categPlatos)
            //{
            //    if (categ != null && categ.Id == id)
            //    {
            //        return categ;
            //    }
            //}

            return null;
        }
    }
}
