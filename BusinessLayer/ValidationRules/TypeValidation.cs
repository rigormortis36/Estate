using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class TypeValidation : AbstractValidator<EntityLayer.Entities.Type>
    {
        public TypeValidation()
        {
            RuleFor(x => x.TypeName).NotEmpty().WithMessage("TİP alanı boş bırakılamaz");
            RuleFor(x => x.SituationId).NotEmpty().WithMessage("Durum alanı boş bırakılamaz");
        }
    }
}
