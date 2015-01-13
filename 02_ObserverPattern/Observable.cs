using System.Collections;

namespace DesignPattern
{
    public class Observable : IObservable
    {
        private IObservable _observable;
        private ArrayList _observers;

        public Observable()
        {
            _observable = this;
            _observers = new ArrayList();
        }

        public Observable(IObservable observable)
            : this()
        {
            _observable = observable;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            int index = _observers.IndexOf(observer);

            if (index >= 0)
                _observers.RemoveAt(index);
        }

        public void NotifyObservers()
        {
            this.NotifyObservers(null);
        }

        public void NotifyObservers(object data)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_observable, data);
            }
        }
    }
}