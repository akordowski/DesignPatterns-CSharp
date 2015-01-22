using System;

namespace DesignPattern.HomeTheater
{
	public class Tuner
	{
		public Amplifier Amplifier { get; set; }

		public Tuner()
		{
		}

		public void On()
		{
			Console.WriteLine("Tuner on");
		}

		public void Off()
		{
			Console.WriteLine("Tuner off");
		}

		public void SetAm()
		{
			Console.WriteLine("Tuner set AM");
		}

		public void SetFm()
		{
			Console.WriteLine("Tuner set FM");
		}

		public void SetFrequency()
		{
			Console.WriteLine("Tuner set frequency");
		}
	}
}