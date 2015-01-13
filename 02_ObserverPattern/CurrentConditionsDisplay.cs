using System;

namespace DesignPattern
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private IObservable _observable;

        private float _temperature;
        private float _humidity;
        private float _pressure;

        public CurrentConditionsDisplay(IObservable observable)
        {
            _observable = observable;
            _observable.RegisterObserver(this);
        }

        public void Display()
        {
            string text = String.Format("Current conditions: {0} C degrees, {1}% humidity and {2} preasure.", _temperature, _humidity, _pressure);
            Console.WriteLine(text);
        }

        public void Update(IObservable observable, object data)
        {
            if (observable.GetType() == typeof(WeatherData))
            {
                WeatherData weatherData = (WeatherData)observable;

                _temperature = weatherData.Temperature;
                _humidity = weatherData.Humidity;
                _pressure = weatherData.Pressure;

                Display();
            }
        }
    }
}