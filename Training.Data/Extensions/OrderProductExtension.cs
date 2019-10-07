using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class OrderProductExtension
    {
        public static DTO.OrderProduct ToDTO(this Models.OrderProduct op)
        {
            return new DTO.OrderProduct
            {
                OrderID = op.OrderID,
                ProductID = op.ProductId,
                Quantity = op.Quantity,
                Orders = op.Order?.ToDTO(),
                Products = op.Product?.toDTO()
                
            };
        }

        public static Models.OrderProduct ToDatabaseModel(this DTO.OrderProduct op)
        {
            return new Models.OrderProduct
            {
                OrderID = op.OrderID,
                ProductId = op.ProductID,
                Quantity = op.Quantity,
                Order = op.Orders?.ToDatabaseModel(),
                Product = op.Products?.ToDatabaseModel()

            };

        }
    }
}
