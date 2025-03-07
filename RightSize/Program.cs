using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.length>7)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
        }
    }
}
