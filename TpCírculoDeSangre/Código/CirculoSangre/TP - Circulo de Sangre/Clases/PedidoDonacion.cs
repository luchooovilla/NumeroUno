using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Circulo_de_Sangre.Clases
{
    public class PedidoDonacion
    {
        public string grupoSangre;
        public int cantSolicitadaDonantes;
        public DateTime fechaDeSolicitud;

        public string GrupoSangre { get => grupoSangre; set => grupoSangre = value; }
        public int CantSolicitadaDonantes { get => cantSolicitadaDonantes; set => cantSolicitadaDonantes = value; }
        public DateTime FechaDeSolicitud { get => fechaDeSolicitud; set => fechaDeSolicitud = value; }


        public void cargarSolicitudDonantes()
        {
            Console.WriteLine("Por favor ingrese la fecha para la que solicita donantes");
            fechaDeSolicitud = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el grupo de Sangre que desea solicitar");
            grupoSangre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese la cantidad de donantes que desea solicitar");
            cantSolicitadaDonantes = Convert.ToInt32(Console.ReadLine());

            notificarDonantes();
            //asignarDonantes();
        }

        public void notificarDonantes()
        {

            Asociado socio = new Asociado();
            DateTime fecha = FechaDeSolicitud;
            Asociado socio1 = new Asociado();

            Console.WriteLine("Se ha enviado una notificacion al numero de telefono "
                    + "\t y un email a la direccion de email " + "Asignando turno para la fecha" + fecha + "\n");
        }
    }
}
