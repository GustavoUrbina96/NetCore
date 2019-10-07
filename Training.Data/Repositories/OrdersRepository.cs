using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;
using Training.Data.Extensions;
using Training.DTO;

namespace Training.Data.Repositories
{

    public class OrdersRepository : IOrdersRepository
    {
        private readonly StoreContext _StoreContext;
        public OrdersRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<DTO.Orders>> GetAll()
        {
            var orders = await _StoreContext.Orders.ToListAsync();
            return orders.Select(s => s.ToDTO()).ToList(); 
        }
    }
}
