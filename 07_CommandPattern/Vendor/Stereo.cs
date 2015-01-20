using System;

namespace DesignPattern.Vendor
{
	public class Stereo
	{
		public string Name { get; private set; }

		public Stereo(string name)
		{
			this.Name = name;
		}

		public void On()
		{
			Console.WriteLine(this.Name + " stereo is on");
		}

		public void Off()
		{
			Console.WriteLine(this.Name + " stereo is off");
		}

		public void SetCD()
		{
			Console.WriteLine(this.Name + " stereo is set for CD input");
		}

		public void SetDVD()
		{
			Console.WriteLine(this.Name + " stereo is set for DVD input");
		}

		public void SetRadio()
		{
			Console.WriteLine(this.Name + " stereo is set for Radio input");
		}

		public void SetVolume(int volume)
		{
			Console.WriteLine(this.Name + " stereo volume set to " + volume);
		}
	}
}