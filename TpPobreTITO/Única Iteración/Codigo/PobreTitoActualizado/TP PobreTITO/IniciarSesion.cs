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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario;
            string contraseña;

            nombreUsuario = txtBoxUser.Text;
            contraseña = txtBoxPassword.Text;

            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\matit\OneDrive\Escritorio\TP PobreTITO\RegistroUsuarios.mdf"";Integrated Security=True");

            string consulta1 = "SELECT nombreUser FROM Usuarios ";
            SqlDataAdapter adapter1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);

            string consulta2 = "SELECT contraseña FROM Usuarios ";
            SqlDataAdapter adapter2 = new SqlDataAdapter(consulta2, conexion);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);

            foreach (DataRow row in dt1.Rows)
            {
                if (dt1.Rows[0].ToString() == nombreUsuario)
                {
                    if (dt2.Rows[0].ToString() == contraseña)
                    {
                        InicioUsuario inicio = new InicioUsuario();
                        inicio.Show();
                        this.Hide();
                    }
                    else { MessageBox.Show("La contraseña ingresada es incorrecta, por favor intente de nuevo"); }
                }
                else { MessageBox.Show("El Nombre de usuario es incorrecto o el usuario no existe, por favor intente de nuevo o registrese"); }

            }
            MessageBox.Show(dt1.Rows[0].ToString() + dt2.Rows[0].ToString());   
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
