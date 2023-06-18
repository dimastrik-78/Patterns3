namespace Task09._06.Chain_of_responsibility
{
    // Отправитель запроса
    public class Client
    {
        public void Main()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            h1.Successor = h2;
            h1.HandleRequest(2);
        }
    }
}