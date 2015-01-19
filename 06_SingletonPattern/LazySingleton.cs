using System;

namespace DesignPattern
{
    public class LazySingleton
    {
        private static LazySingleton _instance = new LazySingleton();

        private LazySingleton()
        {
            Console.WriteLine("Lazy Singleton");
        }

        public static LazySingleton GetInstance()
        {
            return _instance;
        }
    }
}