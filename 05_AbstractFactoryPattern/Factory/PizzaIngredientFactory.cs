using DesignPatterns.Classes.Ingredients;

namespace DesignPatterns.Factory
{
    public abstract class PizzaIngredientFactory
    {
        public abstract Cheese CreateCheese();
        public abstract Clam CreateClam();
        public abstract Dough CreateDough();
        public abstract Pepperoni CreatePepperoni();
        public abstract Sauce CreateSauce();
        public abstract Veggie[] CreateVeggies();
    }
}