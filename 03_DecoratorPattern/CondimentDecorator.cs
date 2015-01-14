namespace DesignPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(string description, Beverage beverage)
            : base(description)
        {
            this.beverage = beverage;
        }

        public override string ToString()
        {
            return this.beverage.ToString() + ", " + base.ToString();
        }
    }
}