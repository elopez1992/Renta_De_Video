using Datos;
using Datos.BaseDatos.Modelos;
using Negocio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRenta
    {
       private DRenta drentas;
        public NRenta()
        {
            drentas= new DRenta();
        }
        public List<Renta> ObtenerRentas()
        {
            return drentas.CategoriaRentasTodas();
        }

        public int Agregarrentas(Renta renta)
        {
            return drentas.GuardarRentas(renta);
        }

        public int Editarentas(Renta renta)
        {
            return drentas.GuardarRentas(renta);

        }
        public int Eliminarrentas(int rentaId)
        {
            return drentas.EliminarCategoria(rentaId);
         }
        public int Agregar(Renta renta)
        {
            renta.FechaRenta = DateTime.Now;
            renta.FechaRetorno = DateTime.Now;
            return drentas.GuardarRentas(renta);
        }
    }
        
    
}
