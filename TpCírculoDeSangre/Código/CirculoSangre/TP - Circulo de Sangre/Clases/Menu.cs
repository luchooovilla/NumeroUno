using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Circulo_de_Sangre.Clases
{
    public class Menu
    {

        public void menuPrincipal(Asociado socio)
        {
            int seleccion = 0;

            do
            {
                Console.WriteLine("Menu de Club de Sangre");
                Console.WriteLine();
                Console.WriteLine("1. Dar de Alta nuevo socio");
                Console.WriteLine("2. Mostrar lista de socios");
                Console.WriteLine("3. Mostrar lista de socios disponibles para donar sangre");
                Console.WriteLine("4. Cargar donacion de sangre");
                Console.WriteLine("5. Cargar solicitud de donantes de sangre");
                Console.WriteLine("6. Exit");

                seleccion = Convert.ToInt32(Console.ReadLine());
                PedidoDonacion solicitudesDonaciones = new PedidoDonacion();

                switch (seleccion)
                {
                    case 1:
                        socio.registrarNuevoSocio();
                        break;

                    case 2:
                        socio.mostrarSocios();
                        break;

                    case 3:
                        socio.mostrarListaDonantes();
                        break;


                    case 4:
                        socio.actualizarFechaDonacion();
                        break;

                    case 5:
                        solicitudesDonaciones.cargarSolicitudDonantes();
                        //solicitudesDonaciones.notificarDonantes();
                        //solicitudesDonaciones.asignarDonantes();
                        break;

                    default:
                        break;


                }


            } while (seleccion != 6);

        }
    }
}
