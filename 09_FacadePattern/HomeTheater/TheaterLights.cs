using System;

namespace DesignPattern.HomeTheater
{
	public class TheaterLights
	{
		public TheaterLights()
		{
		}

		public void On()
		{
			Console.WriteLine("Theater Ceiling Lights on");
		}

		public void Off()
		{
			Console.WriteLine("Theater Ceiling Lights off");
		}

		public void Dim(int value)
		{
			Console.WriteLine("Theater Ceiling Lights dimming to " + value + "%");
		}
	}
}