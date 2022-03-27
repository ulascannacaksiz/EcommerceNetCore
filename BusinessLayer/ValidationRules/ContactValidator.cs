using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("İsim boş olamaz");
            RuleFor(x => x.NameSurname).MinimumLength(2).WithMessage("Geçerli bir isim giriniz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş olamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir mail giriniz");

            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon boş olamaz");
            RuleFor(x => x.Phone).Length(11).WithMessage("Telefon numarası 11 haneli olmalıdır");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Konu boş olamaz");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj boş olamaz");
            RuleFor(x => x.NameSurname).MinimumLength(30).WithMessage("Mesaj alanı 30 karakterden az olamaz");

        }
    } 
}
