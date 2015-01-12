using DesignPattern.FlyBehaviors;
using DesignPattern.QuackBehavior;
using System;

namespace DesignPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("Rubber Duck");
        }
    }
}