﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order_Car
    {
        public int OrderId {  get; set; }
        public Order Order { get; set; }
        public int CarId {  get; set; }
        public Car Car { get; set; }
        public int Quantity {  get; set; }
    }
}
