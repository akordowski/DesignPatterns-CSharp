using DesignPattern.Vendor;

namespace DesignPattern.Commands
{
	public class LightOnCommand : ICommand
	{
		private Light _light;

		public LightOnCommand(Light light)
		{
			_light = light;
		}

		public void Execute()
		{
			_light.On();
		}
	}
}