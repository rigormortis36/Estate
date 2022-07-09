using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CityValidation : AbstractValidator<City>
    {
        public CityValidation()
        {
            RuleFor(x => x.CityName).NotEmpty().WithMessage("ups, boş bırakılamaz");
            RuleFor(x => x.CityName).MaximumLength(15).MinimumLength(20);
        }
    }
}
