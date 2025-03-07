using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
                
        }
    
    [Flags]
    enum Perks
    {
        WarpShift = 1 << 0,
        AutoHeal = 1 << 1,
        Stealth = 1 << 2,
        DoubleJump = 1 << 3
    }
}
