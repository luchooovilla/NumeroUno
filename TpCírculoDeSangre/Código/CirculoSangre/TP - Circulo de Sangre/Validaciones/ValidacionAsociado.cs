using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace CirculoSangre
{
    internal class ValidacionAsociado: AbstractValidator<Asociado>
    {
        public ValidacionAsociado()
        {
            RuleFor(n => n.dni).NotEmpty().MaximumLength(8);
            
            RuleFor(n => n.nombre).NotEmpty();
            
            RuleFor(n => n.apellido).NotEmpty();
            
            RuleFor(n => n.FechaNacimiento).NotEmpty().Must(validarFechaNacimiento);
            
            RuleFor(n => n.domicilio).NotEmpty();
            
            RuleFor(n => n.localidad).NotEmpty();
            
            RuleFor(n => n.telefono).NotEmpty();
            
            RuleFor(n => n.email).NotEmpty();
            
            RuleFor(n => n.GrupoSanguineo).NotEmpty().Must(validarGrupoSanguineo);
        }
        private bool validarGrupoSanguineo(string Grupo)
        {
            if (Grupo == "A" || Grupo == "B" || Grupo == "AB" || Grupo == "0") return true;
            
            return false;
        }
        private bool validarFechaNacimiento(DateTime Fecha)
        {
            if (Fecha.Year > 1922 && Fecha.Year < DateTime.Now.Year) return true;
            
            return false;
        }
    }
}
