namespace Task09._06.Template_Method
{
    // Класс с начальной реализацией, которую можно менять
    public abstract class AbstractClass
    {
        public void TemplateMethod() // Вызов всех операций
        {
            Operation1();
            Operation2();
        }
        
        public abstract void Operation1(); // Первая операция
        public abstract void Operation2(); // Вторая операция
    }
}