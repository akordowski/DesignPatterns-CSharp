namespace DesignPattern
{
    public abstract class Beverage
    {
        public string Description { get; private set; }

        public Beverage(string description)
        {
            this.Description = description;
        }

        public abstract double Cost();

        public override string ToString()
        {
            return this.Description;
        }
    }
}