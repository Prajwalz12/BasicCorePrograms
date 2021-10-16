using System;

namespace Csharpbasic
{
    class Program
    {
        public static void Harmonic(int num)
        {

            double result = 0;

            for (float i = 1; i <= num; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {

            Program.Harmonic(4);

        }

    }
}