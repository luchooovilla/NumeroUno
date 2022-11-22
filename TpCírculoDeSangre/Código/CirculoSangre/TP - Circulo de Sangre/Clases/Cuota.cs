using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Circulo_de_Sangre.Clases
{
    public class Cuota
    {
        #region Propiedades
        private decimal importe;

        private string formaPago;

        private DateTime fechaVencimiento;

        private string descripcion;

        private string estado;
        public decimal Importe
        {
            get => importe;
            set => importe = value;
        }
        public string FormaPago
        {
            get => formaPago;
            set => formaPago = value;
        }
        public DateTime FechaVencimiento
        {
            get => fechaVencimiento;
            set => fechaVencimiento = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public string Estado 
        { 
            get => estado; 
            set => estado = value; 
        }

        #region Constructor
        #endregion

        #region Metodos
        #endregion
    }
}
