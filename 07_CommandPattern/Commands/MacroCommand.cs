namespace DesignPattern.Commands
{
	public class MacroCommand : ICommand
	{
		private ICommand[] _commands;

		public MacroCommand(ICommand[] commands)
		{
			_commands = commands;
		}

		public void Execute()
		{
			foreach (ICommand command in _commands)
			{
				command.Execute();
			}
		}
	}
}