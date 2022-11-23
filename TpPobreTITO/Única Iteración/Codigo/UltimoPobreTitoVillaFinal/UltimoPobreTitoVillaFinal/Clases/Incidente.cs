using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoPobreTitoVillaFinal.Clases
{
    public class Incidente
    {
        #region Propiedades
        private int numeroIncidente;
        private string ubicacion;
        private string descripcion;

        public int NumeroIncidente { get => numeroIncidente; set => numeroIncidente = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion

        #region Constructor
        public Incidente(int numerooincidente, string ubicacion, string descripcion)
        {
            this.numeroIncidente=numerooincidente;
            this.ubicacion=ubicacion;   
            this.descripcion=descripcion;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
