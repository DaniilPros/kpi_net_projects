using System;

namespace Lab2.Soldiers
{
    internal class Dragon : Soldier
    {
        public Dragon()
        {
            LifePoints = 500;
            ArmorPoints = 0;
            AttackPoints = 100;
        }

        public override void Attack()
        {
            Console.WriteLine("Dragon attacks");
        }
    }
}