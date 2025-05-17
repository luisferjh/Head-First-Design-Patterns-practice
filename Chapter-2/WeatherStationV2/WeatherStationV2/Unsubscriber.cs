
namespace WeatherStationV2
{
    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<Measurement>> _list;
        private IObserver<Measurement> _obs;

        public Unsubscriber(List<IObserver<Measurement>> list, IObserver<Measurement> obs)
        {
            _list = list;
            _obs = obs;
        }

        public void Dispose()
        {
            if (_obs != null && _list.Contains(_obs))
                _list.Remove(_obs);
        }
    }
}