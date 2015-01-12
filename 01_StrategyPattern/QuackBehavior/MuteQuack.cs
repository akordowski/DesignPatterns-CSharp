using System;

namespace DesignPattern.QuackBehavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}