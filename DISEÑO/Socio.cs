using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Socio
    {
        public string dni;
        public string nombre;
        public string apellido;
        public DateOnly fechaNacimiento = new DateOnly();
        public string domicilio;
        public string localidad;
        public string telefono;
        public string email;
        public string grupoSanguineo;
        public void ingresardatos()
        {
            Console.Write("Ingrese dni:");
            dni = Console.ReadLine();
            Console.Write("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese su fecha de nacimiento: ");
            fechaNacimiento = DateOnly.Parse(Console.ReadLine());
            Console.Write("Ingrese su domicilio: ");
            domicilio = Console.ReadLine();
            Console.Write("Ingrese su Localidad: ");
            localidad = Console.ReadLine();
            Console.Write("Ingrese su Telefono: ");
            telefono = Console.ReadLine();
            Console.Write("Ingrese su Email: ");
            email = Console.ReadLine();
            Console.Write("Ingrese su grupo sanguineo:");
            grupoSanguineo = Console.ReadLine();  
        }
        public void mostrardatos()
        {
            Console.WriteLine("Dni: " + dni);
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"Fecha Nacimiento: {fechaNacimiento}");
            Console.WriteLine($"Domicilio: {domicilio}");
            Console.WriteLine($"Localidad: {localidad}");
            Console.WriteLine($"Telefono: {telefono}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Grupo Sanguineo: {grupoSanguineo}");
        }
    }
}
