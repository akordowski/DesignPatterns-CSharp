using DesignPattern.HomeTheater;
using System;

namespace DesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Tuner _tuner = new Tuner();
			DvdPlayer _dvd = new DvdPlayer();
			CdPlayer _cd = new CdPlayer();
			Projector _projector = new Projector();
			TheaterLights _lights = new TheaterLights();
			Screen _screen = new Screen();
			PopcornPopper _popper = new PopcornPopper();
			Amplifier _amp = new Amplifier(_tuner, _dvd, _cd);

			HomeTheaterFacade homeTheater = new HomeTheaterFacade(_amp, _tuner, _dvd, _cd, _projector, _lights, _screen, _popper);
			homeTheater.WatchMovie("Raiders of the Lost Ark");
			homeTheater.EndMovie();

			Console.ReadLine();
		}
	}
}