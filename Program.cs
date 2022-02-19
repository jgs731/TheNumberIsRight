using System;

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
        private const string SO_CLOSE = "You\'re so close!. But, still wrong.";

        static void Main(string[] args)
        {
            RandomNum rNum = new RandomNum();
            int playerGuess;
            bool correctAnswer = false;
            
            Console.WriteLine("Welcome to \'The Number is Right\' game!");
            Console.WriteLine("------------------------------------");
            Thread.Sleep(1000);
            int randomGeneratedNumber = rNum.generateNumber();

            while (correctAnswer == false)
            {
                Console.Write("Guess todays number (between 1-100): ");
                playerGuess = Convert.ToInt32(Console.ReadLine());
                {
                    if (playerGuess == randomGeneratedNumber)
                    {
                        Console.WriteLine("Correct answer!");
                        Thread.Sleep(1000);
                        Console.WriteLine("Do you want to play again? (Enter Y/N) ");
                        string response = Console.ReadLine();
                        if (response == "N")
                        {
                            Console.WriteLine("Gracias para jugando, adios!");
                            correctAnswer = true;
                        }
                    }
                    else
                    {
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