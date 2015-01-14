namespace DesignPattern.Coffees
{
    public class Espresso : Beverage
    {
        public Espresso()
            : base("Espresso")
        {
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}