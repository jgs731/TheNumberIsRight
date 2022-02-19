using System;

namespace TheNumberIsRight // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public int GenerateNumber()
        {
            Random random = new Random();
            return random.Next(1,100);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}