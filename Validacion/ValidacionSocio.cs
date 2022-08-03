using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace TP1
{
    internal class ValidacionSocio: AbstractValidator<Socio>
    {
        public ValidacionSocio()
        {
            RuleFor(n => n.dni).NotEmpty().MaximumLength(8);
            RuleFor(n => n.nombre).NotEmpty();
            RuleFor(n => n.apellido).NotEmpty();
            RuleFor(n => n.fechaNacimiento).NotEmpty();
            RuleFor(n => n.domicilio).NotEmpty();
            RuleFor(n => n.localidad).NotEmpty();
            RuleFor(n => n.telefono).NotEmpty();
            RuleFor(n => n.email).NotEmpty();
            RuleFor(n => n.grupoSanguineo).NotEmpty().Must(ValidarGrupoSanguineo);
        }
        private bool ValidarGrupoSanguineo(string Grupo)
        {
            if (Grupo == "A" || Grupo == "B" || Grupo == "AB" || Grupo == "0") return true;
            return false;
        }
        private bool ValidarFechaNacimiento(DateTime Fecha)
        {
            if (Fecha.Year > 1920 && Fecha.Year < DateTime.Now.Year) return true;
            return false;
        }
    }
}
