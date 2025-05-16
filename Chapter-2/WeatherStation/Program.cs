using WeatherStation.Displays;

namespace WeatherStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WheaterData wheaterData = new WheaterData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(wheaterData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(wheaterData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(wheaterData);


            wheaterData.setMeasurements(80, 65, 30.4f);


        }
    }
}