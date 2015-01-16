using DesignPattern.Classes;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NewYorkPizzaStore();

            Pizza pizza = pizzaStore.OrderPizza(PizzaType.CHEESE);
            Console.WriteLine(pizza.ToString() + "\n");

            pizza = pizzaStore.OrderPizza(PizzaType.PEPPERONI);
            Console.WriteLine(pizza.ToString());

            Console.ReadLine();
        }
    }
}