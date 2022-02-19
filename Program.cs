﻿using System;

namespace TheNumberIsRight // Note: actual namespace depends on the project name.
{
    class RandomNum
    {
        public int generateNumber()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RandomNum rNum = new RandomNum();
            int playerGuess;
            bool correctAnswer = false;
            
            Console.WriteLine("Welcome to \'The Number is Right\' game!");
            Console.WriteLine("------------------------------------");
            Thread.Sleep(1000);

            while (correctAnswer == false)
            {
                Console.Write("Guess todays number (between 1-100): ");
                int randomGeneratedNumber = rNum.generateNumber();
                playerGuess = Convert.ToInt32(Console.ReadLine());
                {
                    if (playerGuess == randomGeneratedNumber)
                    {
                        Console.WriteLine("Correct answer!");
                        correctAnswer = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer. Please try again.");
                    }
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}