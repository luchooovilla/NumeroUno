using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimoPobreTitoVillaFinal.Interfaz
{
    public partial class frmMenuInicio : Form
    {
        public frmMenuInicio()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Program.registrousuario.Show();
            this.Hide();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Program.iniciosesion.Show();
            this.Hide();
        }

        private void frmMenuInicio_VisibleChanged(object sender, EventArgs e)
        {
            Program.iniciosesion = null;
            Program.registrousuario = null;
            Program.registroreclamo = null;
            GC.Collect();
            Program.iniciosesion = new frmInicioSesion();
            Program.registrousuario = new frmRegistroNuevoUsuario();
            Program.registroreclamo = new frmRegistroRECLAMO();
        }
    }
}
