using DesignPattern.Classes.Pizzas;
using System;

namespace DesignPattern.Classes
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case PizzaType.CHEESE:
                    pizza = new CheesePizza();
                    pizza.Name = "Chicago Cheese Pizza";
                    break;

                case PizzaType.CLAM:
                    pizza = new ClamPizza();
                    pizza.Name = "Chicago Clam Pizza";
                    break;

                case PizzaType.PEPPERONI:
                    pizza = new PepperoniPizza();
                    pizza.Name = "Chicago Pepperoni Pizza";
                    break;

                case PizzaType.VEGGIE:
                    pizza = new VeggiePizza();
                    pizza.Name = "Chicago Veggie Pizza";
                    break;

                default:
                    throw new ArgumentException(String.Format("Unkonown Pizza Type '{0}'", type));
            }

            return pizza;
        }
    }
}