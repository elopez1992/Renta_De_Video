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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VPeliculas vPeliculas = new VPeliculas();
            vPeliculas.MdiParent = this;
            vPeliculas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VClientes vClientes = new VClientes();
            vClientes.MdiParent=this;
            vClientes.Show();
        }

        private void rentarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VRentas vRentas = new VRentas(); 
            vRentas.MdiParent=this;
            vRentas.Show();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
