using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Circulo_de_Sangre
{
    public class Menu
    {

        public void menuPrincipal(Asociado asociado)
        {
            int seleccion = 0;

            do
            {
                Console.WriteLine("Menu de Club de Sangre");
                Console.WriteLine();
                Console.WriteLine("1. Dar de Alta nuevo asociado");
                Console.WriteLine("2. Mostrar lista de asociados");
                Console.WriteLine("3. Mostrar lista de asociados disponibles para donar sangre");
                Console.WriteLine("4. Cargar donacion de sangre");
                Console.WriteLine("5. Cargar solicitud de donantes de sangre");
                Console.WriteLine("6. Exit");

                seleccion = Convert.ToInt32(Console.ReadLine());
                PedidoDonacion solicitudesDonaciones = new PedidoDonacion();

                switch (seleccion)
                {
                    case 1:
                        asociado.registrarNuevoasociado();
                        break;

                    case 2:
                        asociado.mostrarAsociados();
                        break;

                    case 3:
                        asociado.mostrarListaDonantes();
                        break;


                    case 4:
                        asociado.actualizarFechaDonacion();
                        break;

                    case 5:
                        solicitudesDonaciones.cargarSolicitudDonantes();
                        break;
                        
                    case 6:
                        exit();
                        break;

                    default:
                        break;

                }


            } while (seleccion != 6);

        }
    }
}
