using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string selectedPerk = args[0].ToLower(); 
            int[] count = new int [4]; //creates array

            foreach (char c in selectedPerk) //for each char in args
            {
                switch(c)
                {
                    case 'warpshift': 
                        count[0]++;
                        break;
                    case 'stealth': 
                        count[1]++;
                        break;
                    case 'autoheal': 
                        count[2]++;
                        break;
                    case 'doublejump': 
                        count[3]++;
                        break;
                    default: 
                        Console.WriteLine($"!Unknown perk!");
                        return;
                }
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
