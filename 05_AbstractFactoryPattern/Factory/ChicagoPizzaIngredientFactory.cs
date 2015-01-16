using DesignPatterns.Classes.Ingredients;
using System;

namespace DesignPatterns.Factory
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            Console.WriteLine("Create Cheese");
            return new MozzarellaCheese();
        }

        public override Clam CreateClam()
        {
            Console.WriteLine("Create Clam");
            return new FrozenClams();
        }

        public override Dough CreateDough()
        {
            Console.WriteLine("Create Dough");
            return new ThickCrustDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            Console.WriteLine("Create Pepperoni");
            return new SlicedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            Console.WriteLine("Create Sauce");
            return new PlumTomatoSauce();
        }

        public override Veggie[] CreateVeggies()
        {
            Console.WriteLine("Create Veggies");
            Veggie[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}