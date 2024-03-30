using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public interface IRepository<T> where T : class
    {
        void Agregar (T entidad);
        void AgregarRango(IEnumerable<T> entidades);
        void editar (T entidad);
        void eliminar (T entidad);
        IQueryable<T> Consulta ();

    }
}
