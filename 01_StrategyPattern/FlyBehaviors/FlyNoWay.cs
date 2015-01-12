using System;

namespace DesignPattern.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can't Fly");
        }
    }
}