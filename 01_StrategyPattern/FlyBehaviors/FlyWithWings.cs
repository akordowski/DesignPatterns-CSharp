using System;

namespace DesignPattern.FlyBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}