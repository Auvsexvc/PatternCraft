namespace Strategy
{
    public class Walk : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position++;
        }
    }
}