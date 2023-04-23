namespace DecoratorsTest.Decorators
{
    public class OrderGoodsDecorators : AbstractDecorators
    {
        public OrderGoodsDecorators(AbstractOrder order) : base(order)
        {
        }

        public override decimal Calc()
        {
            var amount = base.Calc();
            return amount;
        }
    }
}
