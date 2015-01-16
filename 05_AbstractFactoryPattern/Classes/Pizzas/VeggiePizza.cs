using DesignPatterns.Factory;
using System;

namespace DesignPattern.Classes.Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
            : base(ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Prepare " + this.Name);

            this.Dough = this.IngredientFactory.CreateDough();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Cheese = this.IngredientFactory.CreateCheese();
            this.Veggies = this.IngredientFactory.CreateVeggies();
        }
    }
}