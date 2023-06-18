namespace Task09._06.Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver observer); // Добавляет в свой лист Observer
        void RemoveObserver(IObserver observer); // Удаляет из своего листа Observer
        void NotifyObservers(); // Оповещает всех Observer из своего листа, если произошло что-то
    }
}