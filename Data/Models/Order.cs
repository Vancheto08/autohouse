﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId {  get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate {  get; set; }
        public string PaymentMethod {  get; set; }
        public string ShippingAddress {  get; set; }
    }
}
