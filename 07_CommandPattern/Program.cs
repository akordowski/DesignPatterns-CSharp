using DesignPattern.Commands;
using DesignPattern.Vendor;
using System;

namespace DesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			CommandExample();
			MacroCommandExample();

			Console.ReadLine();
		}

		public static void CommandExample()
		{
			Light livingRoomLight = new Light("Living Room");
			Light kitchenLight = new Light("Kitchen");
			CeilingFan ceilingFan = new CeilingFan("Living Room");
			GarageDoor garageDoor = new GarageDoor("");
			Stereo stereo = new Stereo("Living Room");

			LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
			LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
			LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
			LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
			CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
			CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
			GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
			GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);
			StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
			StereoOffCommand stereoOff = new StereoOffCommand(stereo);

			RemoteControl remoteControl = new RemoteControl();
			remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
			remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
			remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
			remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

			Console.WriteLine(remoteControl.ToString());

			remoteControl.OnButtonPushed(0);
			remoteControl.OffButtonPushed(0);
			remoteControl.OnButtonPushed(1);
			remoteControl.OffButtonPushed(1);
			remoteControl.OnButtonPushed(2);
			remoteControl.OffButtonPushed(2);
			remoteControl.OnButtonPushed(3);
			remoteControl.OffButtonPushed(3);
		}

		public static void MacroCommandExample()
		{
			Light light = new Light("Living Room");
			TV tv = new TV("Living Room");
			Stereo stereo = new Stereo("Living Room");
			Hottub hottub = new Hottub();

			LightOnCommand lightOn = new LightOnCommand(light);
			StereoOnCommand stereoOn = new StereoOnCommand(stereo);
			TVOnCommand tvOn = new TVOnCommand(tv);
			HottubOnCommand hottubOn = new HottubOnCommand(hottub);

			LightOffCommand lightOff = new LightOffCommand(light);
			StereoOffCommand stereoOff = new StereoOffCommand(stereo);
			TVOffCommand tvOff = new TVOffCommand(tv);
			HottubOffCommand hottubOff = new HottubOffCommand(hottub);

			ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
			ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

			MacroCommand partyOnMacro = new MacroCommand(partyOn);
			MacroCommand partyOffMacro = new MacroCommand(partyOff);

			RemoteControl remoteControl = new RemoteControl();
			remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

			Console.WriteLine(remoteControl.ToString());
			Console.WriteLine("\n--- Pushing Macro On---");
			remoteControl.OnButtonPushed(0);
			Console.WriteLine("\n--- Pushing Macro Off---");
			remoteControl.OffButtonPushed(0);
		}
	}
}