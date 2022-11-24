using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PobreTITO.Clases
{
    public class Usuario
    {
        #region Propiedades
        private int dni;
        private string nombre;
        private string apellido;
        private DateOnly fechaNacimiento;
        private string email;
        private string telefono;
        private string nombreUsuario;
        private string clave;

        public int Dni
        {
            get => dni;
            set => dni = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public DateOnly FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public string NombreUsuario
        {
            get => nombreUsuario;
            set => nombreUsuario = value;
        }
        public string Clave
        {
            get => clave;
            set => clave = value;
        }
        #endregion

        #region Constructor
        public Usuario(int dni, string nombre, string apellido, DateOnly fechaNacimiento, string email, string telefono, string nombreUsuario, string clave)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.email = email;
            this.telefono = telefono;
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
