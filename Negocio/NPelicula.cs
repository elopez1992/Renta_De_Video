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
    public class NPelicula
    {
        private DPeliculas dPeliculas;

        public NPelicula()
        {
            dPeliculas = new DPeliculas();
        }

        public List<Peliculas> TodasLasCategorias()
        {
            return dPeliculas.categoriaPeliculasTodas();
        }

        public List<Peliculas> CategoriasActivas()
        {
            return dPeliculas.categoriaPeliculasTodas().Where(c=> c.Estado==true).ToList();

        }
        public int AgregarCategoria(Peliculas peliculas)
        {
            return dPeliculas.GuardarCategoria(peliculas);
        }
        public int EditarCategoria(Peliculas peliculas)
        {
            return dPeliculas.GuardarCategoria(peliculas);
        }
        public int EliminarCategoria(int peliculaId)
        {
            return dPeliculas.EliminarCategoria(peliculaId);
        }

        public List<CargarCombos> CargarCombos()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var peliculass = CategoriasActivas().Select(c => new
            {
                c.Nombre,
                c.PeliculaId,
                c.Existencia
            })
                                            .ToList();
            foreach (var item in peliculass)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.PeliculaId,
                    Nombre = item.Nombre,
                    Inventario = item.Existencia
                });

            }
            return Datos;


        }
        
    }
}
