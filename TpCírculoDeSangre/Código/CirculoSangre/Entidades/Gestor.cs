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
            Console.WriteLine("Acepta condiciones, métodos e importes de pago? si acepta marque-> s, si NO acepta teclee cualquier otra letra");
            if (Console.ReadLine() == "s")
            {
                Console.WriteLine("Socio Registado");
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
