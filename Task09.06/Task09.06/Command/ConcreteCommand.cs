namespace Task09._06.Command
{
    // Класс с определённой реализацией команды
    public class ConcreteCommand : Command
    {
        readonly Receiver _receiver;
        
        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public override void Execute() // Использование
        {
            _receiver.Operation();
        }

        public override void Undo() // Отмена
        {
            
        }
    }
}