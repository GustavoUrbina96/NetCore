using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Training.DTO
{
    public class OrderProduct
    {
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }


        public Orders Orders { get; set; }

        public Products Products { get; set; }


    }
}
