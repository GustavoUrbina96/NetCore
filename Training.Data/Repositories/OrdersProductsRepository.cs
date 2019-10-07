using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.API.Contracts;
using Training.Data.Extensions;


namespace Training.Data.Repositories
{
    public class OrdersProductsRepository : IOrderProductRepository
    {
        private readonly StoreContext _StoreContext;
        public OrdersProductsRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<DTO.OrderProduct>> GetAll()
        {
            var orderProduct = await _StoreContext.OrderProducts.ToListAsync();
            return orderProduct.Select(s => s.ToDTO()).ToList();
        }
    }
}
