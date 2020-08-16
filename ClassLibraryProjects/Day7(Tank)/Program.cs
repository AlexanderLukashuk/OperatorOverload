using System;
using MyClassLib.WorldOfTanks;

namespace Day7_Tank_
{
    class Program
    {
        const int TANKS_COUNT = 5;
        static void Main(string[] args)
        {
            Tank[] T34Tanks = new Tank[TANKS_COUNT];
            Tank[] PanteraTanks = new Tank[TANKS_COUNT];
            string result;
            for (int i = 0; i < TANKS_COUNT; i++)
            {
                T34Tanks[i] = new Tank("T-34");
                PanteraTanks[i] = new Tank("Pantera");
            }

            for (int i = 0; i < TANKS_COUNT; i++)
            {
                Console.WriteLine($"Round {i + 1};");
                result = T34Tanks[i] * PanteraTanks[i];
                Console.WriteLine($"Winner: {result}");
            }
        }
    }
}
