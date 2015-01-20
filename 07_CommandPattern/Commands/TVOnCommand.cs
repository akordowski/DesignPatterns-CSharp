using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class TVOnCommand : ICommand
	{
		private TV _tv;

		public TVOnCommand(TV tv)
		{
			_tv = tv;
		}

		public void Execute()
		{
			_tv.On();
			_tv.SetInputChannel();
		}
	}
}