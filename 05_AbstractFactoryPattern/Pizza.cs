using DesignPatterns.Classes.Ingredients;
using DesignPatterns.Factory;
using System;

namespace DesignPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public Cheese Cheese { get; set; }

        public Clam Clams { get; set; }

        public Dough Dough { get; set; }

        public Pepperoni Pepperoni { get; set; }

        public Sauce Sauce { get; set; }

        public Veggie[] Veggies { get; set; }

        protected PizzaIngredientFactory IngredientFactory { get; set; }

        protected Pizza(PizzaIngredientFactory ingredientFactory)
        {
            this.IngredientFactory = ingredientFactory;
        }

        abstract public void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake " + this.Name);
        }

        public void Cut()
        {
            Console.WriteLine("Cut " + this.Name);
        }

        public void Box()
        {
            Console.WriteLine("Box " + this.Name);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}