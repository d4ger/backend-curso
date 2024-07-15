using Backend.DTOs;
using FluentValidation;

namespace Backend.Validators
{
    public class BeerInsertValidator : AbstractValidator<BeerInsertDto>
    {
        public BeerInsertValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Error, puto");
            RuleFor(x => x.Name).Length(2, 20).WithMessage("Nombre entre 2 y 20 verguita");
            RuleFor(x => x.BrandId).NotNull().WithMessage(x => "La marca obligatoria verga");
            RuleFor(x => x.BrandId).GreaterThan(0).WithMessage(x => "error con la marca pendejito");
            RuleFor(x => x.Alcohol).GreaterThan(0).WithMessage(x => "El {PropertyName} debe ser mayor que 0, pendejo");
        }
    }
}
