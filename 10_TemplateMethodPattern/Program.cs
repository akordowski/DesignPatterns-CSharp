using System;

namespace DesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Making tea ...");
			Tea tea = new Tea();
			tea.PrepareRecipe();

			Console.WriteLine("\nMaking coffee ...");
			Coffee coffee = new Coffee();
			coffee.PrepareRecipe();

			Console.ReadLine();
		}
	}
}