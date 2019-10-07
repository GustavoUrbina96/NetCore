using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.API.Operations
{
    public class GetProducts
    {
        private readonly IProductsRepository _ProductsRepository;
        
        public GetProducts(IProductsRepository productsRepository)
        {
            _ProductsRepository = productsRepository;
        }

        public async Task<List<DTO.Products>> Execute()
        {
            return await _ProductsRepository.GetAll();
        }
    }
}
