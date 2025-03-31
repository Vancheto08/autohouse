using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        // proba vanche
        public string Proba {  get; set; }
    }
}
