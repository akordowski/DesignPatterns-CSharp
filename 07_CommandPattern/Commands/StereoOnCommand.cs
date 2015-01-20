using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class StereoOnCommand : ICommand
	{
		private Stereo _stereo;

		public StereoOnCommand(Stereo stereo)
		{
			_stereo = stereo;
		}

		public void Execute()
		{
			_stereo.On();
		}
	}
}