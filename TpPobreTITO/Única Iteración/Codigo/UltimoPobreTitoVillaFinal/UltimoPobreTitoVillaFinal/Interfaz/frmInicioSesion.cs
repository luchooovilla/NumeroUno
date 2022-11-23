using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimoPobreTitoVillaFinal.Interfaz
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.menu.Show();
            this.Close();   
        }

        private void frmInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Show();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Program.registrousuario.Show();
            this.Hide();
        }
    }
}
