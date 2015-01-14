namespace DesignPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
            : base("Whip", beverage)
        {
        }

        public override double Cost()
        {
            return 0.10 + this.beverage.Cost();
        }
    }
}