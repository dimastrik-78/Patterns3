namespace Task09._06.Chain_of_responsibility
{
    // Вторая реализация функции обработки запроса
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int condition) // Некая реализацию, завершение запорса или передача запроса дальше
        {
            if (condition == 2)
            {
                
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
}