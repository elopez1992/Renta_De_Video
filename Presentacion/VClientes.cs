using Datos;
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
    public partial class VClientes : Form
    {
        private NClientes nClientes;
        public VClientes()
        {
            InitializeComponent();
            nClientes = new NClientes();
        }

        private void VClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
        
        }

        private void CargarDatos()
        {
            DGVClientes.DataSource = nClientes.TodasLasCategorias();
        }

        private void LimpiarDatos()
        {
            TxtClienteId.Text = "";
            TxtNombre.Text = "";
            TxtApellidos.Text = "";
            TxtFechaIngreso.Text = "";
            CKBEstado.Checked = false;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var clienteId = TxtClienteId.Text.ToString();
            var nombre = TxtNombre.Text.ToString();
            var apellido = TxtApellidos.Text.ToString();
            var fechaIngreso = TxtFechaIngreso.Text.ToString();

            if (string.IsNullOrEmpty(clienteId) || string.IsNullOrWhiteSpace(clienteId))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre))
            {
                errorProvider1.SetError(TxtNombre, "Debe Ingresar nombres");
                return;
            }
            if (string.IsNullOrEmpty(apellido) || string.IsNullOrWhiteSpace(apellido))
            {
                errorProvider1.SetError(TxtApellidos, "Debe Ingresar apellidos");
                return;
            }

            if (agregar)
            {
                nClientes.AgregarCategoria(new Clientes()
                {
                    Nombres = nombre,
                    Apellidos = apellido,
                    FechaIngreso= DateTime.Now,
                    Estado = CKBEstado.Checked
                });
            }
            else
            {
                nClientes.EditarCategoria(new Clientes()
                {
                    ClienteId = int.Parse(clienteId),
                    Nombres = nombre,
                    Apellidos = apellido,
                    FechaIngreso = DateTime.Now,
                    Estado = CKBEstado.Checked

                });
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            var clienteId = TxtClienteId.Text.ToString();
            if (string.IsNullOrEmpty(clienteId) || string.IsNullOrWhiteSpace(clienteId))
            {
                return;
            }
            nClientes.EliminarCategoria(int.Parse(clienteId));
            CargarDatos();
            LimpiarDatos();
        }


        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void DGVClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtClienteId.Text = DGVClientes.CurrentRow.Cells["ClienteId"].Value.ToString();
            TxtNombre.Text = DGVClientes.CurrentRow.Cells["Nombres"].Value.ToString();
            TxtApellidos.Text = DGVClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            TxtFechaIngreso.Text = DGVClientes.CurrentRow.Cells["FechaIngreso"].Value.ToString();
            CKBEstado.Checked = bool.Parse(DGVClientes.CurrentRow.Cells["Estado"].Value.ToString());
        }
    }
}
