using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class CeilingFanOffCommand : ICommand
	{
		private CeilingFan _ceilingFan;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			_ceilingFan.Off();
		}
	}
}