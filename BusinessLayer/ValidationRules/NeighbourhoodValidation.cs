using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class NeighbourhoodValidation : AbstractValidator<Neighbourhood>
    {
        public NeighbourhoodValidation()
        {
            RuleFor(x => x.NeighbourhoodName).NotEmpty().WithMessage("Mahalle ismi boş bırakılama");
            RuleFor(x => x.DistrictId).NotEmpty().WithMessage("Semt ismi boş bırakılama");
        }
    }
}
