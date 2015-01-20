using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class GarageDoorDownCommand : ICommand
	{
		private GarageDoor _garageDoor;

		public GarageDoorDownCommand(GarageDoor garageDoor)
		{
			_garageDoor = garageDoor;
		}

		public void Execute()
		{
			_garageDoor.Down();
		}
	}
}