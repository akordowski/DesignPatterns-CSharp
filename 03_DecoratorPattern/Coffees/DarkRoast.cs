namespace DesignPattern.Coffees
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
            : base("Dark Roast")
        {
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}