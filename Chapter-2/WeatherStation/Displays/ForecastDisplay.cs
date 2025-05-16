using WeatherStation.Interfaces;

namespace WeatherStation.Displays
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private float CurrentPressure { get; set; } = 29.92f;
        private float LastPressure { get; set; }
        private readonly ISubject subject;

        public ForecastDisplay(ISubject subject)
        {
            this.subject = subject;
            subject.registerObserver(this);
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

        //public void update(float temp, float humidity, float pressure)
        //{
        //    LastPressure = CurrentPressure;
        //    CurrentPressure = pressure;
        //    display();

        //}

        public void update()
        {
            if (subject is WheaterData wd)
            {
                LastPressure = CurrentPressure;
                CurrentPressure = wd.Pressure;
                display();
            }


        }
    }
}
