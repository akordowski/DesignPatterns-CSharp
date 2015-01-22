using System;

namespace DesignPattern.HomeTheater
{
	public class Projector
	{
		DvdPlayer DvdPlayer { get; set; }

		public Projector()
		{
		}

		public void On()
		{
			Console.WriteLine("Projector on");
		}

		public void Off()
		{
			Console.WriteLine("Projector off");
		}

		public void TvMode()
		{
			Console.WriteLine("Projector in TV mode (4x3 aspect ratio)");
		}

		public void WideScreenMode()
		{
			Console.WriteLine("Projector in widescreen mode (16x9 aspect ratio)");
		}
	}
}