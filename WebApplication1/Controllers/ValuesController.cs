using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public decimal Get()
        {
            IOrder order = null;
            order = new OrderGoodsDecorators(order);
            order = new OrderCouponDecorators(order);
            var res = order.Exec();
            return res;
        }
    }
}
