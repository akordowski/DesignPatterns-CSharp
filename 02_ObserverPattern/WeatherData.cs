namespace DesignPattern
{
    public class WeatherData : Observable
    {
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }

        public WeatherData()
            : base()
        {
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;

            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            this.NotifyObservers();
        }
    }
}