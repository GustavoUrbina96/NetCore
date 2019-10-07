using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class OrderExtension
    {
        public static DTO.Orders ToDTO(this Models.Order o)
        {
            return new DTO.Orders
            {
                Id = o.Id,
                UserID = o.UserId,
                Status = o.Status,
                Created_at = o.Create_at
            };
        }

        public static Models.Order ToDatabaseModel(this DTO.Orders o)
        {
            return new Models.Order
            {
                Id = o.Id,
                UserId = o.UserID,
                Status = o.Status,
                Create_at = o.Created_at
            };
        }
    }
}
