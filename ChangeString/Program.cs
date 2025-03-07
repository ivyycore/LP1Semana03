using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Tell me something: "); //ask for input
            string frase = Console.ReadLine(); // turn input into string
            Console.Write("Write a character/letter: ") // ask for input
            string letra = Console.Readline(); // turn input intro string

            char letra_to_char = char.Parse(letra); // turns letra into char 
        }
    }
}
