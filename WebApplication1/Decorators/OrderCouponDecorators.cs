namespace WebApplication1.Controllers
{
    public class OrderCouponDecorators : AbstractDecorators
    {
        public OrderCouponDecorators(IOrder order) : base(order)
        {
        }

        protected override decimal Calc()
        {
            var amount = 100;
            return amount - 20;
        }
    }
}
