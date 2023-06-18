namespace Task09._06.Chain_of_responsibility
{
    // Определяет обработку запроса
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }
}