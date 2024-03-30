using Datos.BaseDatos.Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VPeliculas : Form
    {
        private NPelicula nPelicula;
        public VPeliculas()
        {
            InitializeComponent();
            nPelicula = new NPelicula(); 

        }


        private void VPeliculas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            DGVPeliculas.DataSource = nPelicula.TodasLasCategorias();
        }

        private void LimpiarDatos()
        {
            TxtPeliculaId.Text = "";
            TxtNombre.Text = "";
            TxtGenero.Text = "";
            TxtAutores.Text = "";
            TxtExistencia.Text = "";
            TxtPrecioRenta.Text = "";
            CKBEstado.Checked = false;
            errorProvider1.Clear();

        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var peliculaId = TxtPeliculaId.Text.ToString();
            var nombre=  TxtNombre.Text.ToString();
            var genero= TxtGenero.Text.ToString();
            var autores= TxtAutores.Text.ToString();
            var existencia= TxtExistencia.Text.ToString();
            var preciorenta= TxtPrecioRenta.Text.ToString();

            if (string.IsNullOrEmpty(peliculaId) || string.IsNullOrWhiteSpace(peliculaId))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre))
            {
                errorProvider1.SetError(TxtNombre, "Debe Ingresar un Nombre");
                return;
            }
            if (string.IsNullOrEmpty(genero) || string.IsNullOrWhiteSpace(genero))
            {
                errorProvider1.SetError(TxtGenero, "Debe Ingresar un Genero");
                return;
            }

            if (agregar) 
            {
                nPelicula.AgregarCategoria(new Peliculas()
                {
                    Nombre=nombre,
                    Genero=genero,
                    Autores=autores,
                    Existencia= int.Parse(existencia),
                    PrecioRenta= int.Parse(preciorenta),
                    Estado= CKBEstado.Checked
                });
            }
            else
            {
                nPelicula.EditarCategoria(new Peliculas()
                {
                    PeliculaId= int.Parse(peliculaId),
                    Nombre=nombre,
                    Genero=genero,
                    Autores=autores,
                    Existencia= int.Parse(existencia),
                    PrecioRenta= decimal.Parse(preciorenta),
                    Estado= CKBEstado.Checked

                });
            }
            CargarDatos();
            LimpiarDatos();

        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            var peliculaId=TxtPeliculaId.Text.ToString();
            if (string.IsNullOrEmpty(peliculaId) || string.IsNullOrWhiteSpace(peliculaId))
            {
                return;
            }
            nPelicula.EliminarCategoria(int.Parse(peliculaId));
            CargarDatos();
            LimpiarDatos();
        }

        private void DGVPeliculas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtPeliculaId.Text= DGVPeliculas.CurrentRow.Cells["PeliculaId"].Value.ToString();
            TxtNombre.Text= DGVPeliculas.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtGenero.Text = DGVPeliculas.CurrentRow.Cells["Genero"].Value.ToString();
            TxtAutores.Text = DGVPeliculas.CurrentRow.Cells["Autores"].Value.ToString();
            TxtExistencia.Text= DGVPeliculas.CurrentRow.Cells["Existencia"].Value.ToString();
            TxtPrecioRenta.Text = DGVPeliculas.CurrentRow.Cells["PrecioRenta"].Value.ToString();
            CKBEstado.Checked = bool.Parse(DGVPeliculas.CurrentRow.Cells["Estado"].Value.ToString());
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
