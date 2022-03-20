using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator: AbstractValidator<Address>
    {
        public AddressValidator()
        {
            //RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");

            RuleFor(x=>x.Name).NotEmpty().WithMessage("Adres ismi boş olamaz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Adres Başlığı İki karakterden az olamaz");
            RuleFor(x=>x.PersonName).NotEmpty().WithMessage("İsim boş olamaz");
            RuleFor(x=>x.PersonName).MinimumLength(2).WithMessage("Adres Başlığı İki karakterden az olamaz");
            RuleFor(x=>x.PersonSurname).NotEmpty().WithMessage("Soyisim boş olamaz");
            RuleFor(x=>x.PersonSurname).MinimumLength(2).WithMessage("Adres Başlığı İki karakterden az olamaz");
            RuleFor(x => x.Phone).Length(11).WithMessage("Telefon numarası 11 haneli olmalıdır");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon numarası boş olamaz");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("Şehir Seçmelisiniz");
            RuleFor(x => x.ProvinceId).NotEmpty().WithMessage("İlçe Seçmelisiniz");
            RuleFor(x => x.AddressDescription).NotEmpty().WithMessage("Adres boş olamaz");
            RuleFor(x => x.AddressDescription).MinimumLength(50).WithMessage("Adres 50 karakterden az olamaz");
        }
    }
}
