using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Feautres.Libros.Comandos.ModificarLibro
{
    public  class ModificarLibroValidaciones : AbstractValidator<ModificarLibro>
    {
        public ModificarLibroValidaciones() {


            RuleFor(p => p.TituloLibro)
                           .NotEmpty().WithMessage("{PropertyName} no puede ir vacio")
                           .MaximumLength(200).WithMessage("{PropertyName} no debe de exceder de {MaxLength} caracteres");


            RuleFor(p => p.CantidadPaginas)
               .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");

            RuleFor(p => p.Editorial)
               .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");

            RuleFor(p => p.CantidadPaginas)
             .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");


        }

    }
}
