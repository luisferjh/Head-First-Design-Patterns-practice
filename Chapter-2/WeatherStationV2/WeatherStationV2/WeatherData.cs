namespace WeatherStationV2
{
    internal class WeatherData : IObservable<Measurement>
    {
        // instance variable declarations
        public List<IObserver<Measurement>> Observers { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            Observers = new List<IObserver<Measurement>>();
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
            var measurement = new Measurement(Temperature, Humidity, Pressure);
            Observers.ForEach(o => o.OnNext(measurement));
        }

        public void FinishMeasurements()
        {
            Observers.ForEach(o => o.OnCompleted());
        }

        public void ErrorMeasurements(Exception error)
        {
            Observers.ForEach(o => o.OnError(error));
        }

        public IDisposable Subscribe(IObserver<Measurement> observer)
        {
            if (!Observers.Contains(observer))
                Observers.Add(observer);

            return new Unsubscriber(Observers, observer);
        }
    }
}
