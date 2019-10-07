using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.DTO;

namespace Training.API.Contracts
{
    public interface IUsersRepository
    {
        Task<List<User>> GetAll();
    }

    public interface IProductsRepository
    {
        Task<List<Products>> GetAll();
    }
    public interface IOrdersRepository
    {
        Task<List<Orders>> GetAll();
    }

    public interface IOrderProductRepository
    {
        Task<List<OrderProduct>> GetAll();
    }
}
