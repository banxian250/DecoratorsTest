using DecoratorsTest.Decorators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorsTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : ControllerBase
    {
        [HttpGet]
        public JsonResult TestOrder()
        {
            AbstractOrder order = new OrderInit();
            order = new OrderGoodsDecorators(order);
            order = new OrderCouponDecorators(order);

            var res = order.Calc();

            return new JsonResult(new BaseResponse<object>("0", "success", res));
        }
    }
}
