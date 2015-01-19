using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // EagerSingleton
            EagerSingleton eagerSingleton = EagerSingleton.GetInstance();

            // LazySingleton
            LazySingleton lazySingleton = LazySingleton.GetInstance();

            Console.ReadLine();
        }
    }
}