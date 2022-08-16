using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoSangre
{
    internal class Interfaz
    {
        public void SolicitarRegistro(Asociado asociado)
        {
            Console.WriteLine("Ingrese el dni: ");
            asociado.dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre: ");
            asociado.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            asociado.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento: ");
            asociado.FechaNacimiento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su domicilio: ");
            asociado.domicilio = Console.ReadLine();
            Console.WriteLine("Ingrese su localidad: ");
            asociado.localidad = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono: ");
            asociado.telefono = Console.ReadLine();
            Console.WriteLine("Ingrese su email: ");
            asociado.email = Console.ReadLine();
            Console.WriteLine("Ingrese su grupo sanguineo: ");
            asociado.GrupoSanguineo = Console.ReadLine();
            Console.WriteLine("Posee enfermedad cronica?: ");
            asociado.enfermedadCronica = Console.ReadLine();
            Console.WriteLine("Toma medicacion permanente?: ");
            asociado.medicacionPermanente = Console.ReadLine();
            Console.WriteLine("Nombre medicacion: ");
            asociado.nombreMedicacion = Console.ReadLine();
        }
    }
}
