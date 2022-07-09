using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ImagesValidation : AbstractValidator<Images>
    {
        public ImagesValidation()
        {
            RuleFor(x => x.ImageName).NotEmpty().WithMessage("imaj ismi boş bırakılamaz");
            RuleFor(x => x.AdvertId).NotEmpty().WithMessage("ilan bilgisi boş bırakılamaz");
        }
    }
}
