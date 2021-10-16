using System;

namespace Csharpbasic
{
    class Program
    {
        public static void swap(int num1, int num2)
        {
            int num3 = 0;
            Console.WriteLine($"Numbers before swapping are num1= {num1}and num2={num2}");
            num3 = num1;
            num1 = num2;
            num2 = num1;
            Console.WriteLine($"Numbers after swapping are num1={num1}and num2={num2}");
        }

        static void Main(string[] args)
        {

            Program.swap(5, 7);

        }

    }
}