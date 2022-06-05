namespace Adapter
{

        public class Zealot : IUnit
        {
            public void Attack(Target target)
            {
                target.Health -= 8;
            }
        }
    
}