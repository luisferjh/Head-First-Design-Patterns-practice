using WeatherStationV2.Interfaces;

namespace WeatherStationV2.Displays
{
    internal class CurrentConditionsDisplay : IDisplay, IObserver<Measurement>
    {
        private IDisposable _unSuscribe;
        public float Humidity { get; set; }
        public float Tempeture { get; set; }

        public CurrentConditionsDisplay(IObservable<Measurement> wheaterData)
        {
            _unSuscribe = wheaterData.Subscribe(this);
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + Tempeture + "F degrees and " + Humidity + "% humidity");
        }

        public void OnCompleted()
        {
            Console.WriteLine("Weather data completed.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error in weather data: " + error.Message);
        }

        public void OnNext(Measurement value)
        {
            Tempeture = value.Temperature;
            Humidity = value.Humidity;
            display();
        }

        public void UnSuscribe()
        {
            _unSuscribe.Dispose();
        }
    }
}
