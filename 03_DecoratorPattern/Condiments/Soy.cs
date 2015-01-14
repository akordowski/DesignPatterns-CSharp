namespace DesignPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
            : base("Soy", beverage)
        {
        }

        public override double Cost()
        {
            return 0.15 + this.beverage.Cost();
        }
    }
}