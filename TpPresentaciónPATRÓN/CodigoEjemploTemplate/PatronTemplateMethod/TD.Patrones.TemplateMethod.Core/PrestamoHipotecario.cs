using System;

namespace TD.PatronesTemplateMethod.Core
{
    public class PrestamoHipotecario : Prestamo
    {
        public PrestamoHipotecario(Cliente c) : base(c)
        {
        }

        protected override string VerificarAcciones()
        {
            return "Se han validadado correctamente las acciones para asignar un crédito hipotecario";
        }

        protected override string VerificarBalance()
        {
            return "Se ha validado correctamente el balance bancario para un prestamo hipotecario";
        }

        protected override string VerificarPrestamos()
        {
            return "Se han validadado correctamente otros creditos para un prestamo hipotecario";
        }

        protected override string VerificarIngresos()
        {
            return "Se han validado correctamente los ingresos para asignar un prestamo hipotecario";
        } 
    }
}