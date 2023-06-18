namespace Task09._06.Command
{
    
    // Управляет коммандой
    public class Invoker
    {
        private Command _command; // содержит команду
        
        public void SetCommand(Command command) // Устанавливает команду
        {
            _command = command;
        }
        
        public void Run() // Запускает команду
        {
            _command.Execute();
        }
        
        public void Cancel() // Отменяет команду
        {
            _command.Undo();
        }
    }
}