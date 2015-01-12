using System;

namespace DesignPattern
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            this.FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            this.QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}