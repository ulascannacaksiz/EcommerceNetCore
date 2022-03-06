using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int ProvinceId{ get; set; }
        public Province Province { get; set; }
        public string AddressDescription { get; set; }
        public int Phone { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public bool Status { get; set; }

    }
}
