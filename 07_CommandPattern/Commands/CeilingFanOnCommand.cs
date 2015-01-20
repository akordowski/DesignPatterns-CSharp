using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class CeilingFanOnCommand : ICommand
	{
		private CeilingFan _ceilingFan;

		public CeilingFanOnCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			_ceilingFan.High();
		}
	}
}