using DesignPattern.Classes.Pizzas;
using DesignPatterns.Factory;
using System;

namespace DesignPattern.Classes
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch (type)
            {
                case PizzaType.CHEESE:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago Cheese Pizza";
                    break;

                case PizzaType.CLAM:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Chicago Clam Pizza";
                    break;

                case PizzaType.PEPPERONI:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "Chicago Pepperoni Pizza";
                    break;

                case PizzaType.VEGGIE:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "Chicago Veggie Pizza";
                    break;

                default:
                    throw new ArgumentException(String.Format("Unkonown Pizza Type '{0}'", type));
            }

            return pizza;
        }
    }
}