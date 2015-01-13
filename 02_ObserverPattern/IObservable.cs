namespace DesignPattern
{
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
        void NotifyObservers(object data);
    }
}