using System;

namespace Lab2.Soldiers
{
    public class Ciklop:Soldier
    {
        
        public Ciklop()
        {
            LifePoints = 60;
            ArmorPoints = 3;
            AttackPoints = 30;
        }
        public override void Attack()
        {
            Console.WriteLine("Ciklop attack");
        }
    }
}