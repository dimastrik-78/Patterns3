namespace Task09._06.State
{
    // Основной класс для взаимодействия с состоянием
    public class Context
    {
        public Context(State state) // Получает состояние
        {
            State = state;
        }
        
        public State State { get; set; } // Хранит состояние
        
        public void Request() // Меняет состояние Context
        {
            State.Handle(this);
        }
    }
}