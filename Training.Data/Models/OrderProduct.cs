﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Training.Data.Models
{
    public class OrderProduct
    {
        public Guid OrderID { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }



        public Order Order { get; set; }


        public Product Product { get; set; }




    }
}
