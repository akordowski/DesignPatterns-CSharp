namespace DesignPattern.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
            : base("Steamed Milk", beverage)
        {
        }

        public override double Cost()
        {
            return 0.10 + this.beverage.Cost();
        }
    }
}