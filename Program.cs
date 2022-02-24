using System;
using System.IO;

namespace TheNumberIsRight // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private const string WELCOME_MESSAGE = "Welcome to \'The Number is Right\' game!";
        private const string LINE_SEPARATOR = "------------------------------------";
        private const string GUESS_TODAYS_NUMBER = "Guess todays number (between 1-100): ";
        private const string CORRECT = "Well done, correct answer!";
        private const string INCORRECT = "Incorrect guess - you have lost a life";
        private const string THANKS_FOR_PLAYING_SPANISH = "Gracias para jugando, adios!";
        private const string SO_CLOSE = "You\'re so close!. But, still wrong.";
        private const string GAME_OVER = "Game over, no lives remaining - the correct answer was: ";
        private const string PLAY_AGAIN = "Do you want to play again? (Enter Y/N)";        
        static void Main(string[] args)
        {
            Random rNum = new Random();
            int randomGeneratedNumber = rNum.Next(1, 100);
            int playerGuess;
            int lives = 2; // accounts for 3 lives because, zero-index
            bool correctAnswer = false;
            string response = "";
            
            Console.WriteLine(WELCOME_MESSAGE);
            Console.WriteLine(LINE_SEPARATOR);
            Thread.Sleep(1000);

            while (correctAnswer == false)
            {
                Console.Write(GUESS_TODAYS_NUMBER);
                playerGuess = Convert.ToInt32(Console.ReadLine());
                if (playerGuess == randomGeneratedNumber)
                {
                    Console.WriteLine(CORRECT);
                }
                else
                {
                    lives--;
                    if (lives > 0)
                    {
                        if (playerGuess - randomGeneratedNumber < Math.Abs(5.0))
                        {
                            Console.WriteLine(SO_CLOSE);
                        }
                        else
                        {
                            Console.WriteLine(INCORRECT);
                        }
                    }
                    else
                    {
                        Console.WriteLine(GAME_OVER + $"{randomGeneratedNumber}");
                    }
                }
                Thread.Sleep(1500);
                Console.WriteLine(PLAY_AGAIN);
                response = Console.ReadLine();
                if (response == "Y")
                {
                    lives = 2;
                    randomGeneratedNumber = rNum.Next(1, 100);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(THANKS_FOR_PLAYING_SPANISH);
        }
    }
}