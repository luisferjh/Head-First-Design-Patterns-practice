using WeatherStation.Interfaces;

namespace WeatherStation.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        public float Humidity { get; set; }
        public float Tempeture { get; set; }
        private readonly WheaterData wheaterData;

        public CurrentConditionsDisplay(WheaterData wheaterData)
        {
            this.wheaterData = wheaterData;
            this.wheaterData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + Tempeture + "F degrees and " + Humidity + "% humidity");
        }

        //public void update(float temp, float humidity, float pressure)
        //{
        //    Tempeture = temp;
        //    Humidity = humidity;
        //    display();
        //}

        public void update()
        {
            Humidity = wheaterData.Humidity;
            Tempeture = wheaterData.Temperature;
            display();
        }
    }
}
