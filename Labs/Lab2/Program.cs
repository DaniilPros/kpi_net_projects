using System;
using Lab2.Soldiers;

namespace Lab2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var army = new ArmyComposite(){Name = "Army"};
            
            army.AddUnit(new Elf());
            army.AddUnit(new Elf());
            army.AddUnit(new Elf());
            army.AddUnit(new Knight());
            army.AddUnit(new Ork());
            
            var army2 = new ArmyComposite(){Name = "Army2"};
            
            army2.AddUnit(new Ciklop());
            army2.AddUnit(new Minotavr());
            army2.AddUnit(new Kentavr());
            army2.AddUnit(new Gidra());
            
            var army3 = new ArmyComposite(){Name = "Army3"};
            army3.AddUnit(army);
            army3.AddUnit(army2);
            army3.AddUnit(new Knight());
            
            army.Attack();
            army2.Attack();
            army3.Attack();
            Console.ReadKey();
        }
    }
}
