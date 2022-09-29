using System;

namespace TD.PatronesTemplateMethod.Core
{
    public class PrestamoPersonal : Prestamo
    {
        public PrestamoPersonal(Cliente c) : base(c)
        {
        }

        protected override string VerificarAcciones()
        {
          return "No se requiere verificar acciones para un crédito personal";
        }

        protected override string VerificarBalance()
        {
             return "Se ha validado correctamente el balance bancario para un prestamo personal";
        }

        protected override string VerificarPrestamos()
        {
            return "Se han validado correctamente otros creditos para para un prestamo personal";
        }

        protected override string VerificarIngresos()
        {
            return "Se han validado correctamente los ingresos para asignar un prestamo personal";
        }
    }
}