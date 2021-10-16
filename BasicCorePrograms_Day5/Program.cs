using System;

namespace Csharpbasic
{
    class Program
    {
        public Program()
        {
            int num;
            int result = 1;
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                result = 2 * i;
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Program a = new Program();

        }

    }
}