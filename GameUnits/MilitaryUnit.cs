namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }
        public override int Health { get; set; }
        public override float Value { get; }

        public MilitaryUnit(int mov, int health, int attackPower, float value) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
            Health = health + XP;
            Value = AttackPower + XP;
            Value = value;
        }

        public void Attack(Unit u)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $" Attack Power = {AttackPower} | XP = {XP}";
        }
    }
}