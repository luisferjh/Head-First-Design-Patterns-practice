using WeatherStation.Interfaces;

namespace WeatherStation.Displays
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private float MaxTemp { get; set; } = 0.0f;
        private float MinTemp { get; set; } = 200;
        private float TempSum { get; set; } = 0.0f;
        private int NumReadings { get; set; }
        private readonly ISubject subject;


        public StatisticsDisplay(ISubject subject)
        {
            subject = wheaterData;
            subject.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (TempSum / NumReadings) + "/" + MaxTemp + "/" + MinTemp);
        }

        //public void update(float temp, float humidity, float pressure)
        //{

        //    TempSum += temp;
        //    NumReadings++;

        //    if (temp > MaxTemp)
        //    {
        //        MaxTemp = temp;
        //    }

        //    if (temp < MinTemp)
        //    {
        //        MinTemp = temp;
        //    }

        //    display();

        //}

        public void update()
        {
            if (subject is WheaterData wd)
            {
                NumReadings++;

                if (wd.Temperature > MaxTemp)
                {
                    MaxTemp = wd.Temperature;
                }

                if (wd.Temperature < MinTemp)
                {
                    MinTemp = wd.Temperature;
                }

                display();
            }


        }
    }
}
