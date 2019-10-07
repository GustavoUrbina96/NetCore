using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.API.Operations
{
    public class GetOrders
    {
        private readonly IOrdersRepository _OrdersRepository;
        public GetOrders(IOrdersRepository OrdersRepository)
        {
            _OrdersRepository = OrdersRepository;
        }

        public async Task<List<DTO.Orders>> Execute()
        {
            return await _OrdersRepository.GetAll();
        }
    }
}
