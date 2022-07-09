using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class DistrictValidation : AbstractValidator<District>
    {
        public DistrictValidation()
        {
            RuleFor(x => x.DistrictName).NotEmpty().WithMessage("boş bırakılamaz");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("şehir bilgisi boş bırakılamaz");
            RuleFor(x => x.Neighbourhoods).NotEmpty().WithMessage("mahalle bilgisi boş bırakılamaz");
        }
    }
}
