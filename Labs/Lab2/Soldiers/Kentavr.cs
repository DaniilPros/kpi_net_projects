using System;

namespace Lab2.Soldiers
{
    public class Kentavr:Soldier
    {
        public Kentavr()
        {
            LifePoints = 344;
            ArmorPoints = 6;
            AttackPoints = 20;
        }
        public override void Attack()
        {
            Console.WriteLine("Kentavr attack");
        }
    }
}