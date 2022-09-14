using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoSangre
{
    internal class Interfaz
    {
        private List<Asociado> lista = new List<Asociado>();

        public List<Asociado> Lista
        {
            get => lista; set
            {
                lista = value;
            }
        }
        public void SolicitarRegistro(Asociado asociado)
        {
            Console.WriteLine("Ingrese el dni: ");
            asociado.dni = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre: ");
            asociado.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            asociado.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento: Formato: año/mes/dia");
            asociado.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su domicilio: ");
            asociado.domicilio = Console.ReadLine();
            Console.WriteLine("Ingrese su localidad: ");
            asociado.localidad = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono: ");
            asociado.telefono = Console.ReadLine();
            Console.WriteLine("Ingrese su email: ");
            asociado.email = Console.ReadLine();
            Console.WriteLine("Ingrese su grupo sanguineo: (A/B/AB/0) ");
            asociado.GrupoSanguineo = Console.ReadLine();
            Console.WriteLine("Posee enfermedad cronica?: Teclee si/no");
            asociado.enfermedadCronica = Console.ReadLine();
            Console.WriteLine("Toma medicacion permanente?: Teclee si/no");
            asociado.medicacionPermanente = Console.ReadLine();
            Console.WriteLine("Nombre medicacion: ");
            asociado.nombreMedicacion = Console.ReadLine();

            cargarDatos(asociado);
        }
        public void sociosCargados(Asociado asociado)
        {
            Lista.Add(new Asociado()
            {
                dni = "42638860",
                nombre = "Luciano",
                apellido = "Villa",
                GrupoSanguineo = "A",
                FechaNacimiento = new DateTime(1959, 03, 22),
                domicilio = "Cabrera 2533",
                localidad = "San francisco",
                telefono = "3564579569",
                email = "lucianovillaoo@gmail.com",
                enfermedadCronica = null,
                medicacionPermanente = null,
                nombreMedicacion = "---"
            });

        }
        public void cargarDatos(Asociado asociado)
        {
            Lista.Add(new Asociado()
            {
                dni = asociado.dni,
                nombre = asociado.nombre,
                apellido = asociado.apellido,
                FechaNacimiento = asociado.FechaNacimiento,
                domicilio = asociado.domicilio,
                localidad = asociado.localidad,
                telefono = asociado.telefono,
                email = asociado.email,
                GrupoSanguineo = asociado.GrupoSanguineo,
                enfermedadCronica = asociado.enfermedadCronica,
                medicacionPermanente = asociado.medicacionPermanente,
                nombreMedicacion = asociado.nombreMedicacion,
                categoria = asociado.DeterminarCategoria()
            });
        }
        public void mostrarLista(Asociado asociado)
        {
            foreach (var item in lista)
            {
                item.mostrardatos();
            }
        }
    }
}
