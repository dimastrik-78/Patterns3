namespace Task09._06.State
{
    // Основной класс для реализации состояний
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}