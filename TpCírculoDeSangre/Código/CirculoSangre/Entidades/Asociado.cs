using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoSangre
{
    internal class Asociado
    {
        public string dni;
        public string nombre;
        public string apellido;
        public string categoria;
        public DateTime FechaNacimiento = new DateTime();
        public string domicilio;
        public string localidad;
        public string telefono;
        public string email;
        public string GrupoSanguineo;
        public string enfermedadCronica;
        public string medicacionPermanente;
        public string nombreMedicacion;
        public string donoSangre;

        public string DeterminarCategoria()
        {
            if (enfermedadCronica == null && medicacionPermanente == null && (DateTime.Now.Year - FechaNacimiento.Year) > 18 && (DateTime.Now.Year - FechaNacimiento.Year) <= 56)
            {
                categoria = "Activo";
                enfermedadCronica = " ";
            }
            else
            {
                categoria = "Pasivo";
            }
            return categoria;
        }
        public void mostrardatos()
        {
            Console.WriteLine("El Dni: " + dni);
            Console.WriteLine($"Su Nombre: {nombre}");
            Console.WriteLine($"Su apellido: {apellido}");
            Console.WriteLine($"Fecha Nacimiento: {FechaNacimiento}");
            Console.WriteLine($"Domicilio: {domicilio}");
            Console.WriteLine($"Localidad: {localidad}");
            Console.WriteLine($"Telefono: {telefono}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Grupo sanguineo: {GrupoSanguineo}");
        }
    }
}
