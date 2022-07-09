using EntityLayer.Entities;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BusinessLayer.ValidationRules
{
    public class AdvertValidation : AbstractValidator<Advert>
    {
        public AdvertValidation()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Ups, adres bilgisi boş bırakılamaz.");
            RuleFor(x => x.AdvertTitle).NotEmpty().WithMessage("Ups, ilan başlığı boş bırakılamaz.");
            RuleFor(x => x.AdvertTitle).MinimumLength(100).MaximumLength(500).WithMessage("Ups, Minimum:100 Maksimum:500 karakter");
            RuleFor(x => x.AirCondinator).NotEmpty().WithMessage("Ups, klima alanı boş bırakılama");
            RuleFor(x => x.Area).NotEmpty().WithMessage("Ups,bu alan boş bırakılamaz");

            RuleFor(x => x.BathroomNumbers).NotEmpty().WithMessage("Ups, banyo sayısı bırakılamaz");
            RuleFor(x => x.NumberOfRooms).NotEmpty().WithMessage("Ups, oda sayısı alanı boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Ups, açıklama alanı boş bırakılamaz");
            RuleFor(x => x.Floor).NotEmpty().WithMessage("Ups, kat bilgisi boş bırakılamaz");
            RuleFor(x => x.Garage).NotEmpty().WithMessage("Ups, garaj bilgisi boş bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ups, fiyat alanı boş bırakılamaz");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Ups, telefon numarası  boş bırakılamaz");
            RuleFor(x => x.Neighbourhood).NotEmpty().WithMessage("Ups, mahalle bilgisi boş bırakılamaz");
            RuleFor(x => x.DistrictId).NotEmpty().WithMessage("Ups, semt bilgisi boş bırakılamaz");
            RuleFor(x => x.TypeId).NotEmpty().WithMessage("Ups, TİP bilgisi boş bırakılamaz");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("Ups, şehir bilgisi boş bırakılamaz");
            RuleFor(x => x.SituationId).NotEmpty().WithMessage("Ups, durum bilgisi boş bırakılamaz");
            RuleFor(x => x.PhoneNumber).Matches(new Regex(@"([\+]90?)([])?(\([0-9]{3}\))([]?)([0-9]{3})(\s*[\-]?)([0-9]{2})"));

        }

        //private bool IsPhoneNumber(string arg)
        //{
        //    Regex regex = new Regex(@"^[0-9]{10}$");
        //    return regex.IsMatch(arg);
        //}
    }
}
