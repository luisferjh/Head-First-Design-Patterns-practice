using WeatherStationV2.Displays;

namespace WeatherStationV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData wheaterData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(wheaterData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(wheaterData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(wheaterData);


            wheaterData.setMeasurements(80, 65, 30.4f);

            currentDisplay.UnSuscribe();

            Console.WriteLine("-------------- NEW MEASUREMENT--------------------");
            wheaterData.setMeasurements(60, 35, 20.4f);

            wheaterData.FinishMeasurements();
        }
    }
}
