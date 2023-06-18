namespace Task09._06.Memento
{
    // Хранит состояние Originator
    public class Memento
    {
        public Memento(string state)
        {
            State = state;
        }
        
        public string State { get; private set;}
    }
}