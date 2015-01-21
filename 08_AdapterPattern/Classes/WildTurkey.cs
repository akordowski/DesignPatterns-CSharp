using System;

namespace DesignPattern.Classes
{
	public class WildTurkey : ITurkey
	{
		public void Fly()
		{
			Console.WriteLine("Fly a short distance");
		}

		public void Gobble()
		{
			Console.WriteLine("Gobble gobble");
		}
	}
}