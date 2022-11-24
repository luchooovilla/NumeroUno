using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP_PobreTITO
{
    public partial class HistorialDeReportes : Form
    {
        public HistorialDeReportes()
        {
            InitializeComponent();

            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\matit\OneDrive\Escritorio\TP PobreTITO\RegistroUsuarios.mdf"";Integrated Security=True");


            string consulta = "SELECT * FROM RegistroIncidentes ORDER BY Fecha DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHistorial.DataSource = dt;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioUsuario inicio = new InicioUsuario();
            inicio.Show();
            this.Hide();
        }

        
    }
}
