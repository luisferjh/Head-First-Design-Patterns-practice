using WeatherStationV2.Interfaces;

namespace WeatherStationV2.Displays
{
    internal class StatisticsDisplay : IDisplay, IObserver<Measurement>
    {
        private float MaxTemp { get; set; } = 0.0f;
        private float MinTemp { get; set; } = 200;
        private float TempSum { get; set; } = 0.0f;
        private int NumReadings { get; set; }
        private IDisposable _unSuscribe;


        public StatisticsDisplay(IObservable<Measurement> subject)
        {
            _unSuscribe = subject.Subscribe(this);
        }

        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (TempSum / NumReadings) + "/" + MaxTemp + "/" + MinTemp);
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
            NumReadings++;

            if (value.Temperature > MaxTemp)
            {
                MaxTemp = value.Temperature;
            }

            if (value.Temperature < MinTemp)
            {
                MinTemp = value.Temperature;
            }

            display();
        }

        public void UnSuscribe()
        {
            _unSuscribe.Dispose();
        }
    }
}
