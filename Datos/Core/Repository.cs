using Datos.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public RentaVideoContext dbcontext;

        public void Agregar(T Entidad)
        {
            dbcontext.Set<T>().Add(Entidad);
        }

        public void AgregarRango(IEnumerable<T> entidades)
        {
            dbcontext.Set<T>().AddRange(entidades);
            dbcontext.SaveChanges();
        }

        public IQueryable<T> Consulta()
        {
            return dbcontext.Set<T>().AsQueryable();
        }

        public void editar(T entidad)
        {
            dbcontext.Set<T>();
            
        }

        public void eliminar(T entidad)
        {
            dbcontext.Set<T>().Remove(entidad);
        }
    }
}
