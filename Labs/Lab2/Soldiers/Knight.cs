using System;

namespace Lab2.Soldiers
{
    internal class Knight : Soldier
    {
        public Knight()
        {
            LifePoints = 80;
            ArmorPoints = 50;
            AttackPoints = 10;
        }

        public override void Attack()
        {
            Console.WriteLine("Knight attacks");
        }
    }
}