namespace DecoratorsTest.Decorators
{
    public class OrderInit : AbstractOrder
    {
        public override decimal Calc()
        {
            Amount = 100;
            return Amount;
        }
    }
}
