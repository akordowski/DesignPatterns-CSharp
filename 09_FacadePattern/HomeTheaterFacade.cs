using DesignPattern.HomeTheater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
	public class HomeTheaterFacade
	{
		public Amplifier Amp { get; private set; }
		public Tuner Tuner { get; private set; }
		public DvdPlayer Dvd { get; private set; }
		public CdPlayer Cd { get; private set; }
		public Projector Projector { get; private set; }
		public TheaterLights Lights { get; private set; }
		public Screen Screen { get; private set; }
		public PopcornPopper Popper { get; private set; }

		public HomeTheaterFacade(
			Amplifier amp,
			Tuner tuner,
			DvdPlayer dvd,
			CdPlayer cd,
			Projector projector,
			TheaterLights lights,
			Screen screen,
			PopcornPopper popper)
		{
			this.Amp = amp;
			this.Tuner = tuner;
			this.Dvd = dvd;
			this.Cd = cd;
			this.Projector = projector;
			this.Lights = lights;
			this.Screen = screen;
			this.Popper = popper;
		}

		public void WatchMovie(string movie)
		{
			Console.WriteLine("Get ready to watch a movie ...");

			this.Popper.On();
			this.Popper.Pop();
			this.Lights.Dim(10);
			this.Screen.Down();
			this.Projector.On();
			this.Projector.WideScreenMode();
			this.Amp.On();
			this.Amp.SetDvd();
			this.Amp.SetSurroundSound();
			this.Amp.SetVolume(5);
			this.Dvd.On();
			this.Dvd.Play(movie);
		}

		public void EndMovie()
		{
			Console.WriteLine("Shutting movie theater down ...");

			this.Popper.Off();
			this.Lights.On();
			this.Screen.Up();
			this.Projector.Off();
			this.Amp.Off();
			this.Dvd.Stop();
			this.Dvd.Eject();
			this.Dvd.Off();
		}

		public void ListenToCd()
		{ }

		public void EndCd()
		{ }

		public void ListenToRadio()
		{ }

		public void EndRadio()
		{ }
	}
}