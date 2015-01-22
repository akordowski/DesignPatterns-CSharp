using System;

namespace DesignPattern.HomeTheater
{
	public class DvdPlayer
	{
		public Amplifier Amplifier { get; set; }

		public DvdPlayer()
		{
		}

		public void On()
		{
			Console.WriteLine("DVD Player on");
		}

		public void Off()
		{
			Console.WriteLine("DVD Player off");
		}

		public void Eject()
		{
			Console.WriteLine("DVD Player eject");
		}

		public void Play(string movie)
		{
			Console.WriteLine("DVD Player playing '" + movie + "'");
		}

		public void Pause()
		{
			Console.WriteLine("DVD Player pause");
		}

		public void Stop()
		{
			Console.WriteLine("DVD Player stopped");
		}

		public void SetSurroundAudio()
		{
			Console.WriteLine("DVD Player set surround audio");
		}

		public void SetTwoChannelAudio()
		{
			Console.WriteLine("DVD Player set two channel audio");
		}
	}
}