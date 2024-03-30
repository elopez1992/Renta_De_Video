using Datos.BaseDatos.Modelos;
using Datos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRenta
    {
        UnitOfWork _unitOfWork;

        public DRenta()
        {
         _unitOfWork = new UnitOfWork();
        }
        public int RentaId { get; set; }
        public string ClienteId { get; set; }
        public Clientes Clientes { get; set; }
        public string PeliculaId { get; set; }
        public Peliculas Peliculas { get; set; }
        public DateTime FechaRenta { get; set; }
        public DateTime FechaRetorno { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioRenta { get; set; }

        public List<Renta> CategoriaRentasTodas()
        {
            return _unitOfWork.Repository<Renta>().Consulta().Include(c=>c.Clientes).Include(c=>c.Peliculas).ToList();
        }

        public int GuardarRentas(Renta renta)
        {
            if (renta.RentaId == 0)
            {
                
                _unitOfWork.Repository<Renta>().Agregar(renta);
                return _unitOfWork.Guardar();
            }
            else
            {
                var rentaInDb= _unitOfWork.Repository<Renta>().Consulta().FirstOrDefault(c=> c.RentaId== renta.RentaId);
                if (rentaInDb != null)
                {
                    rentaInDb.RentaId= renta.RentaId; 
                    rentaInDb.ClienteId= renta.ClienteId;
                    rentaInDb.PeliculaId= renta.PeliculaId;
                    rentaInDb.FechaRenta = DateTime.Now;
                    rentaInDb.FechaRetorno= DateTime.Now;
                    rentaInDb.Cantidad= renta.Cantidad;
                    rentaInDb.PrecioRenta= renta.PrecioRenta;
                    _unitOfWork.Repository<Renta>().editar(rentaInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }

        public int EliminarCategoria(int rentaId)
        {
            var rentaInDb = _unitOfWork.Repository<Renta>().Consulta().FirstOrDefault(c => c.RentaId == rentaId);
            if (rentaInDb != null)
            {
                _unitOfWork.Repository<Renta>().eliminar(rentaInDb);
                return _unitOfWork.Guardar();
           }
            return 0;
        }


    }
}
