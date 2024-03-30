using Datos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos
{
    public class RentaVideoContext: DbContext
    {
        public RentaVideoContext(): base("name=RentaVideo")
        {


        }
        
        public DbSet <Peliculas> peliculass { get; set; }
        public DbSet <Clientes> clientess {  get; set; }
        public DbSet<Renta> rentass { get; set; }
    }

}
