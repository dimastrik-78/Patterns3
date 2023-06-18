namespace Task09._06.State
{
    // Состояние B
    public class StateB : State
    {
        public override void Handle(Context context) // Смена состояние на следующее
        { 
            context.State = new StateA();
        }
    }
}