using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceCore.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Lütfen ad giriniz")]
        public string Name { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Lütfen soyad giriniz")]
        public string SurName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Lütfen email giriniz")]
        public string Email { get; set; }

        [Display(Name = "Kullanıcı adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şife giriniz")]
        public string Password { get; set; }
        [Display(Name = "Doğum tarihi")]
        [Required(ErrorMessage = "Lütfen doğum tarihi giriniz")]
        public DateTime BirthDate { get; set; }
    }
}
