using AssignmentApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService orderService;
        
       
        public OrderController(IOrderService orderService) 
        {
            this.orderService = orderService;  
        }
        [HttpPost,Route("AddOrder/{productName}/{quantity}")]
        public IActionResult AddOrder(string productName, int quantity) 
        {
            orderService.PlaceOrder(productName, quantity);
        }
    }
}
