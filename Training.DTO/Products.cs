using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class Products
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Merchant_id { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public DateTime Created_at { get; set; }
        public IList<OrderProduct> OrderProducts { get; set; }
    }
}
