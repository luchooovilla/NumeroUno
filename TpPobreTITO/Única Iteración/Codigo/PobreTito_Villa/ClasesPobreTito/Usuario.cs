using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PobreTito_Villa.ClasesPobreTito
{
    internal class Usuario
    {
        public string dni { get; set; }
        public string nombre { get; set; } 
        public string apellido { get; set; } 
        public string email { get; set; }   
        public string telefono { get; set; }    
        public string nombreUsuario { get; set; } 
        public string clave { get; set; }   
        public DateOnly fechaNacimiento { get; set; }

        public Usuario(string dni, string nombre, string apellido, string email, string telefono, string nombreUsuario, string clave, DateOnly fechaNacimiento )
        {
            this.dni = dni; 
            this.nombre = nombre;   
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.nombreUsuario= nombreUsuario;
            this.clave = clave; 
            this.fechaNacimiento= fechaNacimiento;  
        }
    }
}
