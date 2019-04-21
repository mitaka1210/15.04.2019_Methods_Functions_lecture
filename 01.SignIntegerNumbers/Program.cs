using System;

namespace _15._04._2019_Methods_Functions_lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        public static void PrintName()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
