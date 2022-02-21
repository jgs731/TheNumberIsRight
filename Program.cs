using System;

namespace TheNumberIsRight // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private const string SO_CLOSE = "You\'re so close!. But, still wrong.";
        private const string PLAY_AGAIN = "Do you want to play again? (Enter Y/N)";

        private static int generateNumber(Random random)
        {
            return random.Next(1, 100);
        }
        static void Main(string[] args)
        {
            Random rNum = new Random();
            int playerGuess;
            bool correctAnswer = false;
            int lives = 3;
            
            Console.WriteLine("Welcome to \'The Number is Right\' game!");
            Console.WriteLine("------------------------------------");
            Thread.Sleep(1000);
            int randomGeneratedNumber = generateNumber(rNum);

            while (correctAnswer == false && lives > 0)
            {
                Console.Write("Guess todays number (between 1-100): ");
                playerGuess = Convert.ToInt32(Console.ReadLine());
                {
                    if (playerGuess == randomGeneratedNumber)
                    {
                        Console.WriteLine("Correct answer!");
                        Thread.Sleep(1000);
                        Console.WriteLine(PLAY_AGAIN);
                        string response = Console.ReadLine();
                        if (response == "N")
                        {
                            Console.WriteLine("Gracias para jugando, adios!");
                            correctAnswer = true;
                        }
                    }
                    else
                    {
                        lives--;
                        if (lives == 0)
                        {
                            Console.WriteLine("Game over! Correct answer was {0}. ", randomGeneratedNumber);
                            Thread.Sleep(1500);
                            Console.WriteLine("Gracias para jugando, adios!");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect guess - you have {0} guesses left", lives);
                            if (playerGuess > randomGeneratedNumber)
                            {
                                if ((playerGuess - randomGeneratedNumber) > 5)
                                {
                                    Console.WriteLine("Guess is too high. Try again.");
                                }
                                else
                                {
                                    Console.WriteLine(SO_CLOSE);
                                }
                            }
                            else if (playerGuess < randomGeneratedNumber)
                            {
                                if ((playerGuess - randomGeneratedNumber) < -5)
                                {
                                    Console.WriteLine("Guess is too low. Try again."); 
                                }
                                else
                                {
                                    Console.WriteLine(SO_CLOSE);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}