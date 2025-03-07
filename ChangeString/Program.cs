using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Tell me something: "); //ask for input
            string frase = Console.ReadLine(); // turn input into string
            Console.Write("Write a character/letter: "); // ask for input
            string letra = Console.ReadLine(); // turn input intro string

            char letra_to_char = char.Parse(letra); // turns letra into char 

            string novafrase = frase.Replace(letra_to_char,'x');
            Console.WriteLine(novafrase);
        }
    }
}
