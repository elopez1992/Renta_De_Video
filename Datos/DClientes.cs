using Datos.BaseDatos.Modelos;
using Datos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DClientes
    {
        UnitOfWork _unitOfWork;

        public DClientes()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        public List<Clientes> CategoriaCLientetodas()
        {
            return _unitOfWork.Repository<Clientes>().Consulta().ToList();
        }

        public int GuardarCategoria(Clientes clientes)
        {
            if (clientes.ClienteId == 0)
            {
                _unitOfWork.Repository<Clientes>().Agregar(clientes);
                return _unitOfWork.Guardar();
            }

            else
            {
                var clientesInDb = _unitOfWork.Repository<Clientes>().Consulta().FirstOrDefault(c => c.ClienteId == clientes.ClienteId);
                if (clientesInDb != null)
                {
                    clientesInDb.ClienteId= clientes.ClienteId;
                    clientesInDb.Nombres= clientes.Nombres;
                    clientesInDb.Apellidos= clientes.Apellidos;
                    clientesInDb.FechaIngreso=clientes.FechaIngreso;
                    clientesInDb.Estado= clientesInDb.Estado;
                    _unitOfWork.Repository<Clientes>().editar(clientes);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }

        public int EliminarCategoria(int clienteId)
        {
            var clienteInDb=_unitOfWork.Repository<Clientes>().Consulta().FirstOrDefault(c=> c.ClienteId== clienteId);
            if (clienteInDb != null)
            {
                _unitOfWork.Repository<Clientes>().eliminar(clienteInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
