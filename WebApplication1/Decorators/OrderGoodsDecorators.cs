namespace WebApplication1.Controllers
{
    public class OrderGoodsDecorators : AbstractDecorators
    {
        public OrderGoodsDecorators(IOrder order) : base(order)
        {
        }

        protected override decimal Calc()
        {
            var amount = 100;
            return amount;
        }
    }
}
