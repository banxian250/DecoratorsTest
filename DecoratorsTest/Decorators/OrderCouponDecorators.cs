namespace DecoratorsTest.Decorators
{
    public class OrderCouponDecorators : AbstractDecorators
    {
        public OrderCouponDecorators(AbstractOrder order) : base(order)
        {
        }

        public override decimal Calc()
        {
            var amount = base.Calc();
            return amount - 20;
        }
    }
}
