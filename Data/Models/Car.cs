using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public int PublicationYear { get; set; }
        public int Quantity  { get; set; }
        public ICollection<Order_Car> Order_Cars { get; set; }
    }
}
