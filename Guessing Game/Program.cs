﻿using System;

namespace Guessing_Game

{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimt = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit){
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount ++;
                } else
                {
                    outOfGuesses = true;
                }

            }
            if(outOfGuesses)
            {
            Console.Write("You Lose!");
            } else {
            Console.Write("You Win!");
            }

            Console.ReadLine();
        }
    }
}