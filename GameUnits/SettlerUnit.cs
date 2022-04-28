namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Value { get; }
         public SettlerUnit(int mov, int health) : base(mov, health)
        {
            Value = 5;
            Value = Value;
        }
        /*public void Settle(Vector2 a)
        {
            
        }*/
    }
}