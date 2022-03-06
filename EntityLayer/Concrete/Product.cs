using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SizeId { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
