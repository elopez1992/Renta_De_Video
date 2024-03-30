using Datos.BaseDatos.Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VRentas : Form
    {
        
        private NRenta nRenta;
        private NPelicula nPelicula;
        private NClientes nClientes;
        public VRentas()
        {
            InitializeComponent();
            nRenta = new NRenta();
            nClientes = new NClientes();
            nPelicula = new NPelicula();
                      
            
        }

        private void VRentas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarCombos();
        }

        private void CargarDatos()
        {
            var rentas= nRenta.ObtenerRentas().Select(c=> new { c.RentaId,c.ClienteId,c.PeliculaId,c.FechaRenta, c.FechaRetorno, c.Cantidad, c.PrecioRenta });
            DGVRentas.DataSource = rentas.ToList();
        }
     

        private void CargarCombos()
        {
            CBCLienteId.DataSource = nClientes.CargarCombos();
            CBCLienteId.ValueMember = "Valor";
            CBCLienteId.DisplayMember= "Nombre";

            CBPeliculaId.DataSource= nPelicula.CargarCombos();
            CBPeliculaId.ValueMember = "Valor";
            CBPeliculaId.DisplayMember = "Nombre";

            
        }
        

        private void LimpiarDatos()
        {
            TxtRentaId.Text = "";
            TxtFechaRenta.Text = "";
            TxtFechaRetorno.Text = "";
            TxtCantidad.Text = "";
            TxtPrecioRenta.Text = "";
        }

       
        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var rentaId = TxtRentaId.Text.ToString();
            var clienteid = CBCLienteId.SelectedValue.ToString();
            var peliculaid = CBPeliculaId.SelectedValue.ToString();
            var fecharenta = TxtFechaRenta.Text.ToString();
            var fecharetorno = TxtFechaRetorno.Text.ToString();
            var cantidad= TxtCantidad.Text.ToString();
            var preciorenta = TxtPrecioRenta.Text.ToString();

            if (string.IsNullOrEmpty(rentaId) || string.IsNullOrWhiteSpace(rentaId))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(fecharenta) || string.IsNullOrWhiteSpace(fecharenta))
            {
                errorProvider1.SetError(TxtFechaRenta, "Debe Ingresar fecha Renta");
                return;
            }
            if (string.IsNullOrEmpty(fecharetorno) || string.IsNullOrWhiteSpace(fecharetorno))
            {
                errorProvider1.SetError(TxtFechaRetorno, "Debe Ingresar fecha Retorno");
                return;
            }


            if (agregar)
            {
                nRenta.Agregarrentas(new Renta()
                {
                    ClienteId = clienteid,
                    PeliculaId = peliculaid,
                    FechaRenta = DateTime.Parse(fecharenta),
                    FechaRetorno= DateTime.Parse(fecharetorno),
                    Cantidad= int.Parse(cantidad),
                    PrecioRenta= int.Parse(preciorenta)
                });
            }
            else
            {
                nRenta.Editarentas(new Renta()
                {
                    RentaId= int.Parse(rentaId),
                    ClienteId = clienteid,
                    PeliculaId = peliculaid,
                    FechaRenta = DateTime.Now,
                    FechaRetorno = DateTime.Now,
                   Cantidad = int.Parse(cantidad),
                    PrecioRenta = decimal.Parse(preciorenta)

                });
            }
            LimpiarDatos();
            CargarDatos();
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtRentaId.Text.ToString()) ||
                !string.IsNullOrWhiteSpace(TxtRentaId.Text.ToString()))
            {
                if (int.Parse(TxtRentaId.Text.ToString()) != 0)
                {
                    var clienteId = int.Parse(TxtRentaId.Text.ToString());
                    nRenta.Eliminarrentas(clienteId);
                    CargarDatos();
                }
            }
        }



        private void CBPeliculaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var inventario= nPelicula.TodasLasCategorias().Select(c => new { c.Existencia});
            //var cantidad= LblExistencia.Text;
            //cantidad= inventario.ToString();

            Peliculas peliculas = new Peliculas();
            var peliID = peliculas.PeliculaId;

            if (CBPeliculaId.SelectedIndex != peliID)
            {
                peliID = peliculas.Existencia;
                TxtInventario.Text = peliID.ToString();
            }

        }

        private void CBPeliculaId_SelectedValueChanged(object sender, EventArgs e)
        {

                Peliculas peliculas = new Peliculas();
                var peliID= peliculas.PeliculaId;
                
            if (peliID==CBPeliculaId.SelectedIndex)
            {
                var inventario = peliculas.Existencia;
                TxtInventario.Text = inventario.ToString();
            }

        }

        private void DGVRentas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TxtRentaId.Text = DGVRentas.CurrentRow.Cells["RentaId"].Value.ToString();
            var clientess = DGVRentas.CurrentRow.Cells["ClienteId"].Value.ToString();
            CBCLienteId.SelectedValue = clientess;
            var peliculass = DGVRentas.CurrentRow.Cells["PeliculaId"].Value.ToString();
            CBPeliculaId.SelectedValue = peliculass;
            TxtFechaRenta.Text = DGVRentas.CurrentRow.Cells["FechaRenta"].Value.ToString();
            TxtFechaRetorno.Text = DGVRentas.CurrentRow.Cells["FechaRetorno"].Value.ToString();
            TxtCantidad.Text = DGVRentas.CurrentRow.Cells["Cantidad"].Value.ToString();
            TxtPrecioRenta.Text = DGVRentas.CurrentRow.Cells["PrecioRenta"].Value.ToString();
        }
    }
}
