namespace DesignPattern.Coffees
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
            : base("House Blend")
        {
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}