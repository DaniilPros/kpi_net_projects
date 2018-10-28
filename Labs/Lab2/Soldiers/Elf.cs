using System;

namespace Lab2.Soldiers
{
    internal class Elf : Soldier
    {
        public Elf()
        {
            LifePoints = 100;
            ArmorPoints = 0;
            AttackPoints = 20;
        }

        public override void Attack()
        {
            Console.WriteLine("Elf attacks");
        }
    }
}