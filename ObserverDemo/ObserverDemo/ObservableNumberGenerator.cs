using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class ObservableNumberGenerator : IObservable
    {
        private readonly List<IObserver> _observers;
        public int MaxNumber { get; }

        public ObservableNumberGenerator(int maxNumber)
        {
            MaxNumber = maxNumber;
            _observers=new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
