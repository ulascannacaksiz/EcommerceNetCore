using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User:IdentityUser<int>
    {
        //[Key]
       // public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
       // public int PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Byte Gender { get; set; }
        //public string Password { get; set; }
        //public string Email { get; set; }
        //public int UserType { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public string LastLoginIp { get; set; }
    }
}
