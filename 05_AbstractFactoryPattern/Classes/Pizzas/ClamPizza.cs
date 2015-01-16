using DesignPatterns.Factory;
using System;

namespace DesignPattern.Classes.Pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(PizzaIngredientFactory ingredientFactory)
            : base(ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Prepare " + this.Name);

            this.Dough = this.IngredientFactory.CreateDough();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Cheese = this.IngredientFactory.CreateCheese();
            this.Clams = this.IngredientFactory.CreateClam();
        }
    }
}