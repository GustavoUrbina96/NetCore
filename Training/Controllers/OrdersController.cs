using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Training.API.Operations;

namespace Training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IServiceProvider _IoC;

        public OrdersController(IServiceProvider service)
        {
            _IoC = service;
        }
        [HttpGet]
        public async Task<List<DTO.Orders>> GetProducts()
        {
            return await _IoC.GetService<GetOrders>().Execute();
        }
    }
}
