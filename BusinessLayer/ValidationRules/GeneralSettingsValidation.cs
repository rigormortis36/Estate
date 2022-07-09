using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GeneralSettingsValidation : AbstractValidator<GeneralSettings>
    {
        public GeneralSettingsValidation()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("adres bilgisi boş bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-Posta bilgisi boş bırakılamaz");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası boş bırakılamaz");
            RuleFor(x => x.ImageName).NotEmpty().WithMessage("İmaj boş bırakılamaz");
        }
    }
}
