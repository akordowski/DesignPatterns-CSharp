using DesignPattern.FlyBehaviors;
using DesignPattern.QuackBehavior;
using System;

namespace DesignPattern.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Decoy Duck");
        }
    }
}