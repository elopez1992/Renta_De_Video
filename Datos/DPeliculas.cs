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
    public class DPeliculas
    {
        UnitOfWork _unitOfWork;

        public DPeliculas()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Autores { get; set; }
        public int Existencia { get; set; }
        public decimal PrecioRenta { get; set; }
        public bool Estado { get; set; }

        public List<Peliculas> categoriaPeliculasTodas()
        {
            return _unitOfWork.Repository<Peliculas>().Consulta().ToList();
        }

        public int GuardarCategoria(Peliculas peliculas)
        {
            if (peliculas.PeliculaId == 0)
            {
                _unitOfWork.Repository<Peliculas>().Agregar(peliculas);
                return _unitOfWork.Guardar();
            }

            else
            {
                var peliculasInDb= _unitOfWork.Repository<Peliculas>().Consulta().FirstOrDefault(c=>c.PeliculaId== peliculas.PeliculaId);
                if (peliculasInDb != null)
                {
                    peliculasInDb.PeliculaId= peliculas.PeliculaId;
                    peliculasInDb.Nombre= peliculas.Nombre;
                    peliculasInDb.Genero= peliculas.Genero;
                    peliculasInDb.Autores= peliculas.Autores;
                    peliculasInDb.Existencia= peliculas.Existencia;
                    peliculasInDb.PrecioRenta = peliculas.PrecioRenta;
                    peliculasInDb.Estado= peliculas.Estado;
                    _unitOfWork.Repository<Peliculas>().editar(peliculasInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int EliminarCategoria(int peliculaId)
        {
            var peliculaInDb = _unitOfWork.Repository<Peliculas>().Consulta().FirstOrDefault(c => c.PeliculaId == peliculaId);
            if (peliculaInDb != null) 
            {
                _unitOfWork.Repository<Peliculas>().eliminar(peliculaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
