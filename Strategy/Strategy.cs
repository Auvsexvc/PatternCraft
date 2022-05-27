using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// The Strategy Design Pattern can be used, for example, to determine how a unit moves in the StarCraft game.
    /// The pattern consists in having a different strategy to one functionality. A unit, for example, could move by walking or flying.
    /// Complete the code so that when a Viking is flying its position increases by 10 each time it moves. If it is walking then the position is increased by 1.
    /// Viking starts as a ground unit when it is created.
    /// </summary>
    internal class Strategy
    {
        public interface IUnit
        {
            int Position { get; set; }
            void Move();
            IMoveBehavior MoveBehavior { get; set; }
        }

        public interface IMoveBehavior
        {
            void Move(IUnit unit);
        }

        public class Fly : IMoveBehavior
        {

            public void Move(IUnit unit)
            {
                unit.Position += 10;
            }
        }

        public class Walk : IMoveBehavior
        {
            public void Move(IUnit unit)
            {
                unit.Position++;
            }
        }

        public class Viking : IUnit
        {
            public Viking()
            {
                MoveBehavior = new Walk();
            }

            public IMoveBehavior MoveBehavior { get; set; }

            public int Position { get; set; }

            public void Move()
            {
                MoveBehavior.Move(this);
            }
        }

    }
}
