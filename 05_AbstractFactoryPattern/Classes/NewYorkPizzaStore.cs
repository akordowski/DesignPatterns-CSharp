using DesignPattern.Classes.Pizzas;
using DesignPatterns.Factory;
using System;

namespace DesignPattern.Classes
{
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NewYorkPizzaIngredientFactory();

            switch (type)
            {
                case PizzaType.CHEESE:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "New York Cheese Pizza";
                    break;

                case PizzaType.CLAM:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "New York Clam Pizza";
                    break;

                case PizzaType.PEPPERONI:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "New York Pepperoni Pizza";
                    break;

                case PizzaType.VEGGIE:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "New York Veggie Pizza";
                    break;

                default:
                    throw new ArgumentException(String.Format("Unkonown Pizza Type '{0}'", type));
            }

            return pizza;
        }
    }
}