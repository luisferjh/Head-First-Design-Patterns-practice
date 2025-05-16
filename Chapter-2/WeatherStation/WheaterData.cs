using WeatherStation.Interfaces;

namespace WeatherStation
{
    public class WheaterData : ISubject
    {
        // instance variable declarations
        public List<IObserver> Observers { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WheaterData()
        {
            Observers = new List<IObserver>();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            notifyObservers();
        }

        // notify sending the values
        //public void notifyObservers()
        //{
        //    foreach (IObserver observer in Observers)
        //    {
        //        observer.update(Temperature, Humidity, Pressure);
        //    }
        //}

        // in this implementation, we notify all observers without sending the data
        public void notifyObservers()
        {
            foreach (IObserver observer in Observers)
            {
                observer.update();
            }
        }

        public void registerObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            if (Observers.Contains(o))
                Observers.Remove(o);
            else
                Console.WriteLine("Observer not found");

        }
    }
}
