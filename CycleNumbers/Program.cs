using System;

namespace CycleNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 999;
            int stepForNumbers = 7;

            for (int i = 5; i < maxValue; i += stepForNumbers)
            {
                Console.WriteLine(i);
                if(i >= 103)
                    break;
            }
        }
    }
}
