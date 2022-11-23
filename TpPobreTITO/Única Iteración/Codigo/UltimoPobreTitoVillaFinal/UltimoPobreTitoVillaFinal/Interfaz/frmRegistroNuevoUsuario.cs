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
    public partial class frmRegistroNuevoUsuario : Form
    {
        public frmRegistroNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Program.menu.Show();
            this.Close();   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.menu.Show();
            this.Close();
        }

        private void frmRegistroNuevoUusario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Show();
        }
    }
}
