﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MHN.Models
{
    public class CartModel
    {
        public Product product { get; set; }
        public int Quantity { get; set; }
        public string TransportName { get; set; }
    }
}