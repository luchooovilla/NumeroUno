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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lucia\OneDrive\Escritorio\PobreTitoActualizado\TP PobreTITO\RegistroUsuarios.mdf"";Integrated Security=True");

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            string nombreUser;
            string contraseña1;
            string contraseña2;
            string nombre;
            string apellido;
            int dni;
            string direccion;
            int telefono;
            string email;

            nombreUser = txtBoxUserName.Text;
            contraseña1 = txtBoxContraseña1.Text;
            contraseña2 = txtBoxContraseña2.Text;
            nombre = txtBoxNombre.Text;
            apellido = txtBoxApellido.Text;
            dni = Convert.ToInt32(txtBoxDni.Text);
            direccion = txtBoxDireccion.Text;
            telefono = Convert.ToInt32(txtBoxTelefono.Text);
            email = txtBoxEmail.Text;

            if (contraseña1 == contraseña2)
            {
                string contraseña = contraseña1;
                string cargarDatos;

                conexion.Open();

                SqlCommand insert = new SqlCommand($"INSERT INTO Usuarios VALUES('{dni}', '{nombreUser}', '{contraseña}', '{nombre}', '{apellido}', '{direccion}', '{telefono}', '{email}')", conexion);
                insert.ExecuteNonQuery();

                conexion.Close();
                /*SqlCommand cmd = new SqlCommand(cargarUsuario, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@nombreUser", nombreUser);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@email", email);*/


                MessageBox.Show("El Usuario ha sido registrado exitosamente", "Usuario Registrado");
                if (DialogResult.OK == MessageBox.Show("El Usuario ha sido registrado exitosamente"))
                {
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    
                    this.Hide();
                }                
            }
            else
            {
                lblErrorContraseña.Enabled = true;
            }


        }
    }
}
