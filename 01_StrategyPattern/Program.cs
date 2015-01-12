using DesignPattern.Ducks;
using DesignPattern.FlyBehaviors;
using DesignPattern.QuackBehavior;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            // Quack
            // Flying

            mallard.QuackBehavior = new MuteQuack();
            mallard.FlyBehavior = new FlyNoWay();
            mallard.PerformQuack();
            mallard.PerformFly();

            // Silence
            // Can't Fly

            Console.ReadLine();
        }
    }
}