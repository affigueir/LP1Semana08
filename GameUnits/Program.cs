using System;
using System.Numerics;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit bob = new MilitaryUnit(1,2,3,5);
            SettlerUnit billy = new SettlerUnit(7,8);

            bob.Move(new Vector2(2,2));
            billy.Move(new Vector2(8,8));
            
            Console.WriteLine($"Bob Health = {bob.Health} | Bob Value = {bob.Value}");
            Console.WriteLine($"Billy Health = {billy.Health} | Billy Value = {billy.Value}");
        }
        
    }
}
