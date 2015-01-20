using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class HottubOnCommand : ICommand
	{
		private Hottub _hottub;

		public HottubOnCommand(Hottub hottub)
		{
			_hottub = hottub;
		}

		public void Execute()
		{
			_hottub.On();
			_hottub.JetsOn();
		}
	}
}