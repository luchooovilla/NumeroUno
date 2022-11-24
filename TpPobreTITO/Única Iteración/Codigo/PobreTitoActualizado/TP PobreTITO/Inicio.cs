using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PobreTITO
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion inicio = new IniciarSesion();
            inicio.Show();
            this.Hide();
        }

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            RegistrarUsuario inicio = new RegistrarUsuario();
            inicio.Show();
            this.Hide();
        }
    }
}
