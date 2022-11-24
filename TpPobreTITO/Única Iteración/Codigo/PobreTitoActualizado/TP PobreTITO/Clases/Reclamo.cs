using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PobreTITO.Clases
{
    public class Reclamo
    {
        #region Propiedades
        private int numeroReclamo;
        private DateTime fecha;
        private string estado;
        private string descripcion;

        public int NumeroReclamo
        {
            get => numeroReclamo;
            set => numeroReclamo = value;
        }
        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        #endregion

        #region Constructor
        public Reclamo(int numeroReclamo, string estado, string descripcion)
        {

            fecha = DateTime.Now;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
