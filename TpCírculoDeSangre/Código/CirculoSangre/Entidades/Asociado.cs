using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoSangre
{
    internal class Asociado
    {
        public int dni;
        public string nombre;
        public string apellido;
        public string categoria;
        public DateOnly FechaNacimiento = new DateOnly();
        public string domicilio;
        public string localidad;
        public string telefono;
        public string email;
        public string GrupoSanguineo;
        public string enfermedadCronica;
        public string medicacionPermanente;
        public string nombreMedicacion;
        public string donoSangre;

        public void DeterminarCategoria()
        {
            if (enfermedadCronica == null && medicacionPermanente == null && (DateTime.Now.Year - FechaNacimiento.Year) > 18 && (DateTime.Now.Year - FechaNacimiento.Year) <= 56)
            {
                categoria = "Activo";
            }
            else
            {
                categoria = "Pasivo";
            }
        }
    }
}
