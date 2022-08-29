using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoSangre
{
    internal class Cuota
    {
        public decimal importe;
        public string formaPago;
        public DateTime FechaVencimiento = new DateTime();
        public string estado;

        public void MostrarImporte()
        {
            Console.WriteLine("Importe cuota Activo: $4500 ");
            Console.WriteLine("Importe cuota Pasivo: $3000");
        }
    }
}
