using DesignPatterns.Factory;
using System;

namespace DesignPattern.Classes.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(PizzaIngredientFactory ingredientFactory)
            : base(ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Prepare " + this.Name);

            this.Dough = this.IngredientFactory.CreateDough();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Cheese = this.IngredientFactory.CreateCheese();
        }
    }
}