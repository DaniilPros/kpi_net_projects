namespace Lab2.Soldiers
{
    public abstract class Soldier : ArmyUnit
    {
        public int LifePoints { get; protected set; }
        public int ArmorPoints { get; protected set; }
        protected int AttackPoints;
    }
}