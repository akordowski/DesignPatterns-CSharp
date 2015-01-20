using System;

namespace DesignPattern.Vendor
{
	public class CeilingFan
	{
		public string Name { get; private set; }

		public int Speed { get; private set; }

		public CeilingFan(string name)
		{
			this.Name = name;
		}

		public void High()
		{
			this.Speed = 3;
			Console.WriteLine(this.Name + " ceiling fan is on high");
		}

		public void Medium()
		{
			this.Speed = 2;
			Console.WriteLine(this.Name + " ceiling fan is on medium");
		}

		public void Low()
		{
			this.Speed = 1;
			Console.WriteLine(this.Name + " ceiling fan is on low");
		}

		public void Off()
		{
			this.Speed = 0;
			Console.WriteLine(this.Name + " ceiling fan is off");
		}
	}
}