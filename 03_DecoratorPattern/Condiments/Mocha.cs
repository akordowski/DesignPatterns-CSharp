namespace DesignPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
            : base("Mocha", beverage)
        {
        }

        public override double Cost()
        {
            return 0.20 + this.beverage.Cost();
        }
    }
}