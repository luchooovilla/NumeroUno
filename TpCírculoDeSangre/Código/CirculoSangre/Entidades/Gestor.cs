using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoSangre
{
    internal class Gestor
    {
        public void GestionarRegistro(Asociado asociado, Cuota cuota)
        {
            asociado.DeterminarCategoria();
            Console.Clear();
            cuota.MostrarImporte();
            Console.WriteLine("Acepta condiciones, métodos e importes de pago? si/no");
            if (Console.ReadLine() == "si")
            {
                Console.WriteLine("Socio Registado");
            }
            // falta agregar el else
        }

       
    }
}
