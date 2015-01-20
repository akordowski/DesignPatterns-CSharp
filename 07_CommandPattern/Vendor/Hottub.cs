using System;

namespace DesignPattern.Vendor
{
	public class Hottub
	{
		public double Temperature { get; private set; }

		public Hottub()
		{
		}

		public void On()
		{
			this.Temperature = 40;
			Console.WriteLine("Hottub is heating to a steaming " + this.Temperature + " degrees");
		}

		public void Off()
		{
			this.Temperature = 36.7;
			Console.WriteLine("Hottub is cooling to " + this.Temperature + " degrees");
		}

		public void JetsOn()
		{
			Console.WriteLine("Hottub is bubbling!");
		}

		public void JetsOff()
		{
		}
	}
}