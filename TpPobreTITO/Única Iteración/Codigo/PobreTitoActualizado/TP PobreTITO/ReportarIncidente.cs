using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;

namespace TP_PobreTITO
{
    public partial class ReportarIncidente : Form
    {
        public ReportarIncidente()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"");
        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioUsuario inicio = new InicioUsuario();
            inicio.Show();
            this.Hide();
        }

        private void btnReportarIncidente_Click(object sender, EventArgs e)
        {
            string tipoReporte;
            string areaReporte;
            string ubicacionReporte;
            string descripcionReporte;
            DateTime fecha;
            TimeOnly hora;


            fecha= DateTime.Now.Date;
            hora = TimeOnly.FromDateTime(fecha);
            tipoReporte = cbxTipoReporte.Text;
            areaReporte = cbxArea.Text;
            ubicacionReporte = txtBoxUbicacion.Text;
            descripcionReporte = txtBoxDescripcion.Text;

            MessageBox.Show("El Reporte de Incidente ha sido registrado exitosamente", "Incidente Registrado");
            if (DialogResult.OK == MessageBox.Show("El Reporte de Incidente ha sido registrado exitosamente"))
            {
                conexion.Open();
                SqlCommand insert = new SqlCommand($"INSERT INTO RegistroIncidentes VALUES('{fecha}', '{hora}', '{tipoReporte}', '{areaReporte}', '{ubicacionReporte}', '{descripcionReporte}')", conexion);
                insert.ExecuteNonQuery();
                conexion.Close();

                InicioUsuario inicio = new InicioUsuario();
                inicio.Show();
                this.Hide();
            }
        }
    }
}
