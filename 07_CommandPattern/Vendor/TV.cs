using System;

namespace DesignPattern.Vendor
{
	public class TV
	{
		public string Name { get; private set; }

		public TV(string name)
		{
			this.Name = name;
		}

		public void On()
		{
			Console.WriteLine(this.Name + " TV is on");
		}

		public void Off()
		{
			Console.WriteLine(this.Name + " TV is off");
		}

		public void SetInputChannel()
		{
			Console.WriteLine(this.Name + " TV channel is set for DVD");
		}

		public void SetVolume(int volume)
		{
			Console.WriteLine(this.Name + " TV volume set to " + volume);
		}
	}
}