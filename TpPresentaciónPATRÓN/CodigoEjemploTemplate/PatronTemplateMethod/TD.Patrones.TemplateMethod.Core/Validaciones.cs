using System;
using System.Collections.Generic;
using System.Text;

namespace TD.PatronesTemplateMethod.Core
{
    public abstract class Validaciones
    {
        protected Cliente _cliente;

        public string[] Verificar()
        {
            var msg = new List<string>();
            msg.Add($"Verificando crédito para {_cliente.Nombre}");
            msg.Add($"......");
            msg.Add(VerificarAcciones());
            msg.Add(VerificarBalance());
            msg.Add(VerificarPrestamos());
            msg.Add(VerificarIngresos());
            msg.Add($"Credito aprobado correctamente");

            return msg.ToArray();
        }

        protected abstract string VerificarAcciones();
        protected abstract string VerificarBalance();
        protected abstract string VerificarIngresos();
        protected abstract string VerificarPrestamos();
    }
}