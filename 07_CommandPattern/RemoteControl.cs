using DesignPattern.Commands;
using System;
using System.Text;

namespace DesignPattern
{
	public class RemoteControl
	{
		private ICommand[] _onCommands;
		private ICommand[] _offCommands;

		public RemoteControl()
		{
			int len = 7;

			_onCommands = new ICommand[len];
			_offCommands = new ICommand[len];

			NoCommand noCommand = new NoCommand();

			for (int i = 0; i < len; i++)
			{
				_onCommands[i] = noCommand;
				_offCommands[i] = noCommand;
			}
		}

		public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
		{
			_onCommands[slot] = onCommand;
			_offCommands[slot] = offCommand;
		}

		public void OnButtonPushed(int slot)
		{
			_onCommands[slot].Execute();
		}

		public void OffButtonPushed(int slot)
		{
			_offCommands[slot].Execute();
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("\n------ Remote Control -------\n");

			for (int i = 0; i < _onCommands.Length; i++)
			{
				sb.AppendLine(String.Format("[slot {0}] {1}    {2}", i, _onCommands[i].GetType().FullName, _offCommands[i].GetType().FullName));
			}

			return sb.ToString();
		}
	}
}