using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;
        //Save Changes
        int Guardar();

        //BeginTransaccion
        void ComenzarTransaccion();

        //RollBackTransaction
        void ReversarTransaccion();

        //CommitTransaction
        void ConfirmarTransaccion();
    }
}
