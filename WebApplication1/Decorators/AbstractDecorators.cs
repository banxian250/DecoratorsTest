namespace WebApplication1.Controllers
{
    public abstract class AbstractDecorators : IOrder
    {
        private IOrder _order;
        public AbstractDecorators(IOrder order)
        {
            _order = order;
        }

        protected abstract decimal Calc();

        public decimal Exec()
        {
            decimal res = 0;
            if(_order == null)
            {
                res = Calc();
            }
            else
            {
                _order.Exec();
                res = Calc();
            }
            return res;
        }
    }
}
