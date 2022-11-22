using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace CirculoSangre
{
    internal class ValidacionDonaciobn: AbstractValidator<Donacion>
    {
        public ValidacionDonacion()
        {
            RuleFor(n => n.dni).NotEmpty().MaximumLength(8);
            
            RuleFor(n => n.nombre).NotEmpty();
            
            RuleFor(n => n.apellido).NotEmpty();
            
            RuleFor(n => n.FechaNacimiento).NotEmpty().Must(validarFechaNacimiento);
            
            RuleFor(n => n.domicilio).NotEmpty();
            
            RuleFor(n => n.localidad).NotEmpty();
            
            RuleFor(n => n.telefono).NotEmpty();
            
            RuleFor(n => n.fechaUltimaDonacion).NotEmpty();
            
            RuleFor(n => n.fechaDonacion).NotEmpty();
            
            RuleFor(n => n.descripcion).NotEmpty();
        }
    }
}
