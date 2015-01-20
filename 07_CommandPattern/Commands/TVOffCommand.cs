using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class TVOffCommand : ICommand
	{
		private TV _tv;

		public TVOffCommand(TV tv)
		{
			_tv = tv;
		}

		public void Execute()
		{
			_tv.Off();
		}
	}
}