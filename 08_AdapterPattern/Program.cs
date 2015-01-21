using DesignPattern.Classes;
using System;

namespace DesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			MallardDuck duck = new MallardDuck();
			WildTurkey turkey = new WildTurkey();
			IDuck turkeyAdapter = new TurkeyAdapter(turkey);

			Console.WriteLine("The Turkey says ...");
			turkey.Gobble();
			turkey.Fly();

			Console.WriteLine("\nThe Duck says ...");
			TestDuck(duck);

			Console.WriteLine("\nThe TurkeyAdapter says ...");
			TestDuck(turkeyAdapter);

			Console.ReadLine();
		}

		static void TestDuck(IDuck duck)
		{
			duck.Quack();
			duck.Fly();
		}
	}
}