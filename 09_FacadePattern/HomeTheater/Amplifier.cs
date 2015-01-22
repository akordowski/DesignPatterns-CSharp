using System;

namespace DesignPattern.HomeTheater
{
	public class Amplifier
	{
		public CdPlayer CdPlayer { get; private set; }
		public DvdPlayer DvdPlayer { get; private set; }
		public Tuner Tuner { get; private set; }

		public Amplifier(Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer)
		{
			this.Tuner = tuner;
			this.DvdPlayer = dvdPlayer;
			this.CdPlayer = cdPlayer;
		}

		public void On()
		{
			Console.WriteLine("Amplifier on");
		}

		public void Off()
		{
			Console.WriteLine("Amplifier off");
		}

		public void SetCd()
		{
			Console.WriteLine("Amplifier set CD");
		}

		public void SetDvd()
		{
			Console.WriteLine("Amplifier set DVD");
		}

		public void SetStereoSound()
		{
			Console.WriteLine("Amplifier stereo sound on (2 speakers)");
		}

		public void SetSurroundSound()
		{
			Console.WriteLine("Amplifier surround sound on (5 speakers, 1 subwoofer)");
		}

		public void SetTurner()
		{
			Console.WriteLine("Amplifier set Turner");
		}

		public void SetVolume(int value)
		{
			Console.WriteLine("Amplifier setting volume to " + value);
		}
	}
}