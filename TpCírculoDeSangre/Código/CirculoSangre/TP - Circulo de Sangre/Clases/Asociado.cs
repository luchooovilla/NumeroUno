using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Circulo_de_Sangre.Clases
{
    public class Asociado
    {
        int dni;
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        string domicilio;
        string localidad;
        int telefono;
        string email;
        string grupoSanguineo;
        string factor;
        string categoria;
        bool enfermedadesCronicas;
        bool tomaMedicacionPermanente;
        DateTime fechaUltimaDonacion;
        string estadoDonante;



        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string GrupoSanguineo { get => grupoSanguineo; set => grupoSanguineo = value; }
        public string Factor { get => factor; set => factor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public bool EnfermedadesCronicas { get => enfermedadesCronicas; set => enfermedadesCronicas = value; }
        public bool TomaMedicacionPermanente { get => tomaMedicacionPermanente; set => tomaMedicacionPermanente = value; }
        public DateTime FechaUltimaDonacion { get => fechaUltimaDonacion; set => fechaUltimaDonacion = value; }
        public string EstadoDonante { get => estadoDonante; set => estadoDonante = value; }

        public List<Asociado> socios = new List<Asociado>();
        public List<Asociado> donantes = new List<Asociado>();

        public void preCargaSocios()
        {

            Asociado Socio1 = new Asociado();
            Socio1.Dni = 32444565;
            Socio1.Nombre = "Carlos";
            Socio1.Apellido = "Gomez";
            Socio1.FechaNacimiento = new DateTime(1985, 10, 19);
            Socio1.Domicilio = "Jose Hernandez 2044";
            Socio1.Localidad = "San Fernando";
            Socio1.Telefono = 15659588;
            Socio1.Email = "cachogomez@gmail.com";
            Socio1.GrupoSanguineo = "A";
            Socio1.Factor = "negativo";
            Socio1.EnfermedadesCronicas = false;
            Socio1.TomaMedicacionPermanente = false;
            Socio1.fechaUltimaDonacion = new DateTime(2021, 9, 15);
            Socio1.Categoria = asignarCategoria(Socio1.FechaNacimiento, Socio1.TomaMedicacionPermanente, Socio1.EnfermedadesCronicas);
            Socio1.EstadoDonante = aptoParaDonar(Socio1.fechaUltimaDonacion);


            Asociado Socio2 = new Asociado();
            Socio2.Dni = 46546546;
            Socio2.Nombre = "Jorge";
            Socio2.Apellido = "Perez";
            Socio2.FechaNacimiento = new DateTime(1995, 9, 11);
            Socio2.Domicilio = "Honduras 943";
            Socio2.Localidad = "San Francisco";
            Socio2.Telefono = 15898774;
            Socio2.Email = "perecitojorge@gmail.com";
            Socio2.GrupoSanguineo = "B";
            Socio2.Factor = "negativo";
            Socio2.EnfermedadesCronicas = false;
            Socio2.TomaMedicacionPermanente = false;
            Socio2.fechaUltimaDonacion = new DateTime(2021, 8, 5);
            Socio2.Categoria = asignarCategoria(Socio2.FechaNacimiento, Socio2.TomaMedicacionPermanente, Socio2.EnfermedadesCronicas);
            Socio2.EstadoDonante = aptoParaDonar(Socio2.fechaUltimaDonacion);


            socios.Add(Socio1);
            socios.Add(Socio2);
        }

        public string asignarCategoria(DateTime fecha, bool medicacion, bool enfermedad)
        {
            string categoria = null;

            int edad = CalcularEdad(fecha);

            if (edad >= 18 || edad <= 56)
            {
                if (medicacion == false && enfermedad == false)
                {
                    categoria = "Activo";

                }

            }
            else
            {
                categoria = "Pasivo";
            }
            return categoria;
        }


        public static int CalcularEdad(DateTime fechaNacimiento)
        {

            DateTime fechaActual = DateTime.Today;


            if (fechaNacimiento > fechaActual)
            {
                Console.WriteLine("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - fechaNacimiento.Year;


                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }
        }

        public bool validarFactorSanguineo()
        {
            bool apto = false;

            Console.WriteLine("Por Favor Ingrese su factor Sanguineo, positivo o negativo");
            factor = Console.ReadLine();
            if (factor == "negativo")
            {
                apto = true;
            }

            return apto;
        }


        public void registrarNuevoSocio()
        {
            if (validarFactorSanguineo())
            {
                Console.WriteLine("Por Favor Ingrese su Dni");
                dni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Por Favor ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Por favor Ingrese su Apellido");
                apellido = Console.ReadLine();
                Console.WriteLine("Por Favor Ingrese su fecha de Nacimiento, dd/mm/aaaa");
                fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Por favor ingrese su domicilio");
                domicilio = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su localidad");
                localidad = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su telefono");
                telefono = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Por favor ingrese su direccion de email");
                email = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su grupo sanguineo, A, B, AB o 0");
                grupoSanguineo = Console.ReadLine();
                Console.WriteLine("Por Favor Ingrese su factor Sanguineo, positivo o negativo");
                factor = Console.ReadLine();
                Console.WriteLine("Por favor ingrese si tiene alguna enfermedad cronica, ingrese true si es afirmativa su respuesta o false si es negativa su respuesta");
                enfermedadesCronicas = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Por favor ingrese si toma alguna medicacion de forma permanente, ingrese true si es afirmativa su respuesta o false si es negativa su respuesta");
                tomaMedicacionPermanente = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Por favor ingrese fecha de ultima donacion");
                fechaUltimaDonacion = Convert.ToDateTime(Console.ReadLine());

                categoria = asignarCategoria(fechaNacimiento, tomaMedicacionPermanente, enfermedadesCronicas);
                estadoDonante = aptoParaDonar(fechaUltimaDonacion);


                socios.Add(new Asociado
                {
                    Dni = dni,
                    Nombre = nombre,
                    Apellido = apellido,
                    FechaNacimiento = fechaNacimiento,
                    Domicilio = domicilio,
                    Localidad = localidad,
                    Telefono = telefono,
                    Email = email,
                    GrupoSanguineo = grupoSanguineo,
                    Factor = factor,
                    EnfermedadesCronicas = enfermedadesCronicas,
                    TomaMedicacionPermanente = tomaMedicacionPermanente,
                    FechaUltimaDonacion = fechaUltimaDonacion,
                    Categoria = categoria,
                    EstadoDonante = estadoDonante
                });
            }
            else
            {
                Console.WriteLine("Usted no tiene la condicion principal para poder ser registrado como socio");
            }

        }


        public void mostrarSocios()
        {
            foreach (var item in socios)
            {
                item.datosDelSocio();
            }
        }


        public void datosDelSocio()
        {
            Console.WriteLine("Dni: " + dni);
            Console.WriteLine("Nombre: " + nombre + " " + "Apellido: " + apellido);
            Console.WriteLine("Fecha de Nacimiento: " + fechaNacimiento);
            Console.WriteLine("Domicilio: " + domicilio);
            Console.WriteLine("Localidad: " + localidad);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Grupo Sanguineo: " + grupoSanguineo + " " + "Factor: " + factor);
            Console.WriteLine("Enfermedades Cronicas: " + enfermedadesCronicas);
            Console.WriteLine("Toma Medicacion de forma Permanente: " + tomaMedicacionPermanente);
            Console.WriteLine("Categoria: " + categoria);
            Console.WriteLine("Fecha de ultima donacion: " + fechaUltimaDonacion);
            Console.WriteLine("Estado de donante: " + estadoDonante);
            Console.WriteLine("\n");

        }


        public string aptoParaDonar(DateTime fecha)
        {
            string puedeDonar;
            double cantidadDias = (DateTime.Now - fecha).TotalDays;
            if (cantidadDias >= 180)
            {
                puedeDonar = "Puede Donar Sangre";
            }
            else
            {
                puedeDonar = "No Puede Donar Sangre";
            }

            return puedeDonar;

        }


        public void crearListaDonantes()
        {
            foreach (var item in socios)
            {
                if (item.estadoDonante == "Puede Donar Sangre")
                {
                    donantes.Add(item);
                }
            }


        }

        public void mostrarListaDonantes()
        {
            crearListaDonantes();
            foreach (var socio in donantes)
            {
                socio.datosDelSocio();
            }
        }

        public void actualizarFechaDonacion()
        {
            Donacion donacion = new Donacion();
            donacion.preCargaDonacion();

            foreach (var item in socios)
            {
                if (donacion.Dni == item.Dni)
                {
                    item.FechaUltimaDonacion = donacion.FechaDonacion;
                }
            }
        }
    }
}
