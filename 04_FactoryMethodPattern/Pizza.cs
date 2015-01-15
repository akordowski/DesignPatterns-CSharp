using System;

namespace DesignPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        protected Pizza()
        {
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare " + this.Name);
        }

        public void Bake()
        {
            Console.WriteLine("Bake " + this.Name);
        }

        public void Cut()
        {
            Console.WriteLine("Cut " + this.Name);
        }

        public void Box()
        {
            Console.WriteLine("Box " + this.Name);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}