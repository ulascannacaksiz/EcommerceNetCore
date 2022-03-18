using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Price { get; set; }
        public DateTime OrderDateTime { get; set; }
        public byte OrderStatus { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public string UserIP { get; set; }
        public string PaymentMethod { get; set; }
        public string CartNumber { get; set; }
        public string Cargo { get; set; }
        public string CargoTracking { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DeliveryDate{ get; set; }
    }
}
