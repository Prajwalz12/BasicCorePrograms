using System;

namespace Csharpbasic
{
    class Program
    {

        static void Main(string[] args)
        {

            string alphabet;
            alphabet = Console.ReadLine();
            if (alphabet == "a" || alphabet == "e" || alphabet == "i" || alphabet == "o" || alphabet == "u")
            {
                Console.WriteLine($"{alphabet} is a vowel");
            }
            else
            {
                Console.WriteLine($"{alphabet} is a consonant");
            }
        }

    }
}