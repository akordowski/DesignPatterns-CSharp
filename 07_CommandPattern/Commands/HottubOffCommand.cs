using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class HottubOffCommand : ICommand
	{
		private Hottub _hottub;

		public HottubOffCommand(Hottub hottub)
		{
			_hottub = hottub;
		}

		public void Execute()
		{
			_hottub.JetsOff();
			_hottub.Off();
		}
	}
}