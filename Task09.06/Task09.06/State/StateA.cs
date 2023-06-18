namespace Task09._06.State
{
    // Состояние A
    public class StateA : State
    {
        public override void Handle(Context context) // Смена состояние на следующее
        {
            context.State = new StateB();
        }
    }
}