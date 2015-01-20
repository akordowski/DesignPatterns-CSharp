using System;

namespace DesignPattern.Vendor
{
	public class GardenLight
	{
		public DateTime DuskTime { get; set; }
		public DateTime DawnTime { get; set; }

		public GardenLight(string name)
		{
		}

		public void ManualOn()
		{
		}

		public void ManualOff()
		{
		}
	}
}