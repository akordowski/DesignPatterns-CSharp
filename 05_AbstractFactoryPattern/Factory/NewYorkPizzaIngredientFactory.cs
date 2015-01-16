using DesignPatterns.Classes.Ingredients;
using System;

namespace DesignPatterns.Factory
{
    public class NewYorkPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            Console.WriteLine("Create Cheese");
            return new ReggianoCheese();
        }

        public override Clam CreateClam()
        {
            Console.WriteLine("Create Clam");
            return new FreshClams();
        }

        public override Dough CreateDough()
        {
            Console.WriteLine("Create Dough");
            return new ThinCrustDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            Console.WriteLine("Create Pepperoni");
            return new SlicedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            Console.WriteLine("Create Sauce");
            return new MarinaraSauce();
        }

        public override Veggie[] CreateVeggies()
        {
            Console.WriteLine("Create Veggies");
            Veggie[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}