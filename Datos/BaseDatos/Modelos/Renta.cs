using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos.Modelos
{
    public class Renta
    {
        [Key]
        public int RentaId { get; set; }
        [Required]
        [MaxLength(75)]
        public string ClienteId { get; set; }
        public Clientes Clientes { get; set; }
        [Required]
        [MaxLength(75)]
        public string PeliculaId { get; set; }
        public Peliculas Peliculas { get; set; }
        [Required]
        public DateTime FechaRenta { get; set; }
        [Required]
        public DateTime FechaRetorno { get; set; }
        [Required]
        public int Cantidad {  get; set; }
        [Required]
        public decimal PrecioRenta { get; set; }
    }
}
