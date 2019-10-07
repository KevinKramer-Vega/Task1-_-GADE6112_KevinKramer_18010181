using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Task1_POE
{
    public enum Direction
    {
        North,
        South,
        East,
        West
    }
    abstract class BaseUnit
    {
        protected Random r = new Random();
        protected int xPos;
        protected int yPos;
        protected int health;
        protected int maxHealth;//????
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected string team;
        protected string symbol;
        protected bool stance;
        

        public abstract void Move(Direction d);
        public abstract void CombatMelee(MeleeUnit Opponent);
        public abstract void CombatRanged(RangedUnit Opponent);
        public abstract void WithInRangeRUnit(RangedUnit withinRange);
        public abstract void WithInRangeMUnit(MeleeUnit withinRange);
        public abstract void ReturnPositionClosest();
        public abstract void Death();
        public abstract override string ToString();
    }
}
