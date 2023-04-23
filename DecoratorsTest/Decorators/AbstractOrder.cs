namespace DecoratorsTest.Decorators
{
    public abstract class AbstractOrder
    {
        public decimal Amount { get; set; }
        public abstract decimal Calc();

        public void Exec()
        {
            Amount = Calc();
        }
    }
}
