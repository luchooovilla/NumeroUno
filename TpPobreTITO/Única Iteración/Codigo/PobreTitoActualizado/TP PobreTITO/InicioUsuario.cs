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
    public partial class InicioUsuario : Form
    {
        public InicioUsuario()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnReportarIncidente_Click(object sender, EventArgs e)
        {
            ReportarIncidente inicio = new ReportarIncidente();
            inicio.Show();
            this.Hide();
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            HistorialDeReportes inicio = new HistorialDeReportes();
            inicio.Show();
            this.Hide();
        }
    }
}
