using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.API.Operations
{
    public class GetOrdersProducts
    {
        private readonly IOrderProductRepository _OrdersProductsRepository;

        public GetOrdersProducts(IOrderProductRepository orderProductRepository)
        {
            _OrdersProductsRepository = orderProductRepository;
        }

        public async Task<List<DTO.OrderProduct>> Execute()
        {
            return await _OrdersProductsRepository.GetAll();
        }
    }
}
