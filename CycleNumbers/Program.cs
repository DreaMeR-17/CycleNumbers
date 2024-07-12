using System;

namespace CycleNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 103;
            int minNumber = 5;
            int step = 7;

            for (int i = minNubmer; i <= maxNumber; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
