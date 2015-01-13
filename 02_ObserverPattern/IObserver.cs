namespace DesignPattern
{
    public interface IObserver
    {
        void Update(IObservable observable, object data);
    }
}