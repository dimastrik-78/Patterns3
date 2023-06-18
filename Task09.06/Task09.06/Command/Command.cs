namespace Task09._06.Command
{
    // Абстрактная команда, может быть интерфейсом, для реализаций команд
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}