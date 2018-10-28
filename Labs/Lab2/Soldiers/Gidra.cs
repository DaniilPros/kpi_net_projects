using System;

namespace Lab2.Soldiers
{
    public class Gidra:Soldier
    {
        public Gidra()
        {
            LifePoints = 344;
            ArmorPoints = 6;
            AttackPoints = 20;
        }
        
        public override void Attack()
        {
            Console.WriteLine("Gidra attack");
        }
    }
}