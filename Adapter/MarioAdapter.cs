namespace Adapter
{

        public class MarioAdapter : IUnit
        {
            private Mario _mario;

            public MarioAdapter(Mario mario)
            {
                _mario = mario;
            }

            public void Attack(Target target)
            {
                target.Health -= _mario.jumpAttack();
            }
        }
    
}