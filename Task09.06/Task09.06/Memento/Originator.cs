namespace Task09._06.Memento
{
    // Создаёт и хранит своё состояние
    public class Originator
    {
        public Memento CreateMemento() // Создаёт состояние
        {
            return new Memento(State);
        }
        
        public string State { get; set; } // Состояние Orugubator
        
        public void SetMemento(Memento memento) // Устанавливает состояние
        {
            State = memento.State;
        }
    }
}