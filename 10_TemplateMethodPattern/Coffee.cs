using System;

namespace DesignPattern
{
	public class Coffee : CaffeineBeverage
	{
		protected override void Brew()
		{
			Console.WriteLine("Dripping Coffee through filter");
		}

		protected override void AddCondiments()
		{
			Console.WriteLine("Adding Sugar and Milk");
		}
	}
}