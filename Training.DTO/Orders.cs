using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class Orders
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public string Status { get; set; }
        public DateTime Created_at { get; set; }
        public IList<OrderProduct> OrderProducts { get; set; }

    }
}
