using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class ArmyComposite : ArmyUnit
    {
        public string Name { get; set; }
        private readonly List<ArmyUnit> _armyUnits = new List<ArmyUnit>();

        public void AddUnit(ArmyUnit unit)
        {
            _armyUnits.Add(unit);
        }

        public void RemoveUnit(ArmyUnit unit)
        {
            _armyUnits.Remove(unit);
        }

        public ArmyUnit GetArmyUnit(int index)
        {
            return _armyUnits[index];
        }

        public override void Attack()
        {
            Console.WriteLine($"Army composite {Name} attack");
            foreach (var unit in _armyUnits)
                unit.Attack();
            Console.WriteLine($"Army {Name} attack finish" + Environment.NewLine);
        }
    }
}