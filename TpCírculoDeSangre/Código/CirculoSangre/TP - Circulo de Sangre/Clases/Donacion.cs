using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Circulo_de_Sangre
{
    public class Donacion
    {
        int dni;
        DateTime fechaDonacion;
        DateTime fechaUltimaDonacion;
        string apellido;
        string nombre;
        string descripcion;

        private int Dni 
        {
            get => dni; 
            set => dni = value; 
        }
        private DateTime FechaDonacion 
        { 
            get => fechaDonacion; 
            set => fechaDonacion = value; 
        }
        private DateTime FechaUltimaDonacion 
        { 
            get => fechaUltimaDonacion; 
            set => fechaUltimaDonacion = value; 
        }
        private string Apellido 
        { 
            get => apellido; 
            set => apellido = value; 
        }
        private string Nombre 
        { 
            get => nombre; 
            set => nombre = value; 
        }
        private string descripcion
        {
            get => descripcion; 
            set => descripcion = value;
        }
        
        List<Donacion> donacion = new List<Donacion>();

        public void preCargaDonacion()
        {
            Donacion donacion1 = new Donacion();

            donacion1.FechaDonacion = new DateTime(2022, 10, 22);
            donacion1.Apellido = "Gomez";
            donacion1.Nombre = "Carlos";
            donacion1.Dni = 32444565;

            donacion.Add(donacion1);

        }

    }
}
