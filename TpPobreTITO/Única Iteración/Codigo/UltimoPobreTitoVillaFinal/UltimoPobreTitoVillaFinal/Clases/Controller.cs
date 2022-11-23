using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UltimoPobreTitoVillaFinal.Clases
{
    public class Controller
    {
        #region Propiedades
        //public int dni;
        //public string nombre, apellido, email, telefono, nombreUsuario, clave;
        //public DateOnly fechaNacimiento;
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public void registro()
        {
            Usuario usuario = new Usuario(dni, nombre, apellido, fechaNacimiento, email, telefono, nombreUsuario, clave);
            Program.conexion.Open();
            usuario.nuevoUsuario(Program.conexion);
            MessageBox.Show("Usuario registrado");
            Program.conexion.Close();
            return null;
        }

        public DataTable obtenerIncidentes()
        {
            Program.conexion.Open();
            SqlCommand select = new SqlCommand("select * from Incidentes", Program.conexion);
            DateTable resultados = new DateTable();
            SqlDataAdapter adapter = new SqlDataAdapter(select);
            adapter.Fill(resultados);
            Program.conexion.Close();
            return resultados
        }

        public void gestionarReclamo(string numeroReclamo, DateTime fecha, string descripcion, string estado)
        {
            Program.conexion.Open();
            Reclamo reclamo = new Reclamo(numeroReclamo, fecha, descripcion);
            reclamo.nuevoReclamo(idUsuario, Program.conexion);
            MessageBox.Show("Reclamo registrado correctamente");
            Program.conexion.Close();
        }
        #endregion
    }

}
