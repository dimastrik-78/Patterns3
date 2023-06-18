namespace Task09._06.Strategy
{
    // Конкретный класс, где используется одна из нескольких реализаций Strategy
    public class Context
    {
        public IStrategy ContextStrategy { get; set; }
 
        // Передача параметров, где будет одна из N реализаций Strategy
        public Context(IStrategy strategy)
        {
            ContextStrategy = strategy;
        }
 
        // Использование реализации Strategy
        public void ExecuteAlgorithm()
        {
            ContextStrategy.Algorithm();
        }
    }
}