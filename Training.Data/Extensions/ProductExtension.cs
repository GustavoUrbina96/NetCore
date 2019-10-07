using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class ProductExtension
    {
        public static DTO.Products toDTO(this Models.Product p)
        {
            return new DTO.Products
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            };
        }

        public static Models.Product ToDatabaseModel(this DTO.Products p)
        {
            return new Models.Product
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            };
        }
        
    }
}
