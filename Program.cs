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
        static void Main(string[] args)
        {
            RandomNum rNum = new RandomNum();
            Console.WriteLine(rNum.generateNumber());
        }
    }
}