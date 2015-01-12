using DesignPattern.FlyBehaviors;
using DesignPattern.QuackBehavior;
using System;

namespace DesignPattern.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.FlyBehavior = new FlyWithWings();
            this.QuackBehavior = new DuckQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
        }
    }
}