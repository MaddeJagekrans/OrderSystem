using WorkOrderSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace WorkOrderSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static readonly IEnumerable<OrderModel> Orders = new[]
        {
            new OrderModel {Id = 1, CompanyName = "Test AB", ContactPerson = "Testare", 
                Description = "Trasig sak", Email = "test@test.com", PhoneNumber = "070-0000000", 
                AssignedWorker = "Nisse", OrderType = 1
            }
        };

        [HttpGet("{orderType:int}")]
        public OrderModel[] Get(int orderType)
        {
            OrderModel[] orders = Orders.Where(i => i.OrderType == orderType).ToArray();
            return orders;
        }

    }
}