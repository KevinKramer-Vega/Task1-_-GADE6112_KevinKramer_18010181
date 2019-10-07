using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Task1_POE
{
    class MeleeUnit : BaseUnit
    {
        public bool Stance
        {
            get { return stance; }
            set { stance = value; }
        }
        public string Team
        {
            get { return team; }
            set { team = value; }
        }
        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int MaxHealth
        {
            get { return maxHealth; }
            
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int XPos
        {
            get { return base.xPos; }
            set { xPos = value; }
        }
        public int YPos
        {
            get { return base.yPos; }
            set { yPos = value; }
        }
        public string Symbol
        {
            get { return base.symbol; }
            set { symbol = value; }
        }

        public override void Move(Direction d)
        {
            int distance = r.Next(0, 4);
            switch (d)
            {
                case Direction.North:
                    yPos -= distance;
                    break;
                case Direction.South:
                    xPos += distance;
                    break;
                case Direction.East:
                    yPos += distance;
                    break;
                case Direction.West:
                    xPos -= distance;
                    break;
                default:
                    break;
            }

        }
        public override void CombatRanged(RangedUnit Opponent)
        {
            Opponent.Health -= this.attack;
            stance = true;
        }
        public override void CombatMelee(MeleeUnit Opponent)
        {
            Opponent.Health -= this.attack;
            stance = true;
        }
        public override void WithInRangeRUnit(RangedUnit withinRange)
        {

        }
        public override void WithInRangeMUnit(MeleeUnit withinRange)
        {
        }
        public override void ReturnPositionClosest()
        {
        }
        public override void Death()
        {

        }
        public override string ToString()
        {
            return "Unit: " + symbol + "\n Unit Health : " + health + "\n Unit Max Health: " + maxHealth
               + "\n Speed: " + speed + "\nAttack: " + attack + "\n Attack Range : " + attackRange
               + "Team: " + team + "\n Stance : " + stance;
        }

        public MeleeUnit(string symbol, string team, int xPos, int yPos, int attack, int attackRange, int health,int speed,  bool stance)
        {
            this.Symbol = symbol;
            this.Team = team;
            this.XPos = xPos;
            this.YPos = yPos;
            this.Attack = attack;
            this.AttackRange = attackRange;
            this.Health = health;
            this.Speed = speed;
            this.Stance = stance;
        }
    }
}
