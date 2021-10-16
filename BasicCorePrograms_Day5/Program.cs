using System;

namespace Csharpbasic
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;

            Random rng = new Random();
            coin = rng.Next(0, 2);
            if (coin == 0)
            {
                Console.Write("Tails");
            }
            else
            {
                Console.Write("Heads");
            }
        }
    }
}