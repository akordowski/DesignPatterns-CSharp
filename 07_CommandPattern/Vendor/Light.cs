using System;

namespace DesignPattern.Vendor
{
	public class Light
	{
		public string Name { get; private set; }

		public Light(string name)
		{
			this.Name = name;
		}

		public void On()
		{
			Console.WriteLine(this.Name + " light is on");
		}

		public void Off()
		{
			Console.WriteLine(this.Name + " light is off");
		}
	}
}