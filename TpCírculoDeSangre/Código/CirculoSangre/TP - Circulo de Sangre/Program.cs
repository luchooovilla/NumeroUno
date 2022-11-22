using System;
using System.Runtime.CompilerServices;
using TP___Circulo_de_Sangre.Clases;

namespace TP___Circulo_de_Sangre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asociado asociado = new Asociado();
            asociado.preCargaSocios();
            Menu menu= new Menu();

            menu.menuPrincipal(asociado);
            //socio.mostrarListaDonantes(); 
        }
            
    }
    
}
