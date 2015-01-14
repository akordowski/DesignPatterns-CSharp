namespace DesignPattern.Coffees
{
    public class Decaf : Beverage
    {
        public Decaf()
            : base("Decaf")
        {
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}