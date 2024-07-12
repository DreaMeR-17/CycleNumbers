using System;

namespace CycleNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int requiredMaxNumber = 103;
            int stepForNumbers = 7;

            for (int i = 5; i <= requiredMaxNumber; i += stepForNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
