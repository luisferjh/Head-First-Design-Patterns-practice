using WeatherStationV2.Interfaces;

namespace WeatherStationV2.Displays
{
    internal class ForecastDisplay : IDisplay, IObserver<Measurement>
    {
        private float CurrentPressure { get; set; } = 29.92f;
        private float LastPressure { get; set; }
        private IDisposable _unSuscribe;


        public ForecastDisplay(IObservable<Measurement> subject)
        {
            _unSuscribe = subject.Subscribe(this);
        }

        public void display()
        {
            Console.WriteLine("Forecast: ");
            if (CurrentPressure > LastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (CurrentPressure == LastPressure)
                Console.WriteLine("More of the same");
            else if (CurrentPressure < LastPressure)
                Console.WriteLine("Watch out for cooler, rainy weather");

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

            LastPressure = CurrentPressure;
            CurrentPressure = value.Pressure;
            display();

        }

        public void UnSuscribe()
        {
            _unSuscribe.Dispose();
        }
    }
}
