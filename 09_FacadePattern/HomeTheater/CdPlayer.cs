using System;

namespace DesignPattern.HomeTheater
{
	public class CdPlayer
	{
		public Amplifier Amplifier { get; set; }

		public CdPlayer()
		{
		}

		public void On()
		{
			Console.WriteLine("CD Player on");
		}

		public void Off()
		{
			Console.WriteLine("CD Player off");
		}

		public void Eject()
		{
			Console.WriteLine("CD Player eject");
		}

		public void Play()
		{
			Console.WriteLine("CD Player play");
		}

		public void Pause()
		{
			Console.WriteLine("CD Player pause");
		}

		public void Stop()
		{
			Console.WriteLine("CD Player stopped");
		}
	}
}