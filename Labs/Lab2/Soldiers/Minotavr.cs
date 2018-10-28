using System;

namespace Lab2.Soldiers
{
    public class Minotavr:Soldier
    {
        public Minotavr()
        {
            LifePoints = 344;
            ArmorPoints = 6;
            AttackPoints = 20;
        }
        public override void Attack()
        {
            Console.WriteLine("Minotavr attack");
        }
    }
}