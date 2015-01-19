using System;

namespace DesignPattern
{
    public class EagerSingleton
    {
        private static EagerSingleton _instance;

        private EagerSingleton()
        {
            Console.WriteLine("Eager Singleton");
        }

        public static EagerSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EagerSingleton();
            }

            return _instance;
        }
    }
}