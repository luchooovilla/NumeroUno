using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socio socio = new Socio();
            socio.ingresardatos();
            var validation = new ValidacionSocio();
            var resultado = validation.Validate(socio); //guarda resultados de validacion
            if(resultado.IsValid)
            {
                socio.mostrardatos();
            }
            else
            {
                foreach (var error in resultado.Errors)
                {
                    Console.WriteLine(error.PropertyName + ": " + error.ErrorMessage);
                }
            }
        }
    }
}
