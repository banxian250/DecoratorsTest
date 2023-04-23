namespace DecoratorsTest.Decorators
{
    public abstract class AbstractDecorators : AbstractOrder
    {
        private AbstractOrder _order;
        public AbstractDecorators(AbstractOrder order)
        {
            _order = order;
        }

        public override decimal Calc()
        {
            var amount = _order.Calc();
            return amount;
        }
    }
}
