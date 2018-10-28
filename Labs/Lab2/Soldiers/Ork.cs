    using System;
    
    namespace Lab2.Soldiers
    {
        internal class Ork : Soldier
        {
            public Ork()
            {
                LifePoints = 70;
                ArmorPoints = 10;
                AttackPoints = 10;
            }
    
            public override void Attack()
            {
                Console.WriteLine("Ork attacks");
            }
        }
    }