using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect2_StrategyPattern
{
    public class Viking : IUnit
    {
        public IMoveBehavior MoveBehavior { get; set; }
        public int Position { get; set; }

        public Viking()
        {
            this.MoveBehavior = new Walk();
        }

        public void Move()
        {
            MoveBehavior.Move(this);
        }
    }

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
            unit.Position += 1;
        }
    }
    
}
