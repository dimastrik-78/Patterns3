namespace Task09._06.Chain_of_responsibility
{
    // Первая реализация функции обработки запроса
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int condition) // Некая реализацию, завершение запорса или передача запроса дальше
        {
            if (condition == 1)
            {
                
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
}