using System.Xml.Linq;

namespace Libreria.Managers
{
    public interface IManager<T>
    {
        void Registrar(T item);
        T[] GetTodos();
    }
}
