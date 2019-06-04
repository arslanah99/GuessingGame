using System;

namespace Guessing_Game

{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";

            while(guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }
            Console.Write("You Win!");

            Console.ReadLine();
        }
    }
}