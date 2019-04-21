using System;

namespace _11._MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            string operations = Console.ReadLine();

            int number2 = int.Parse(Console.ReadLine());
           double result = Calculate(number, operations, number2);

        }

        public static double Calculate(int number, string operations, int number2)
        {
            double result = 0;
            switch (operations)
            {
                case "+":
                    Console.WriteLine(number + number2);
                    break;
                case "*":
                    Console.WriteLine(number * number2);
                    break;
                case "/":
                    Console.WriteLine(number / number2);
                    break;
                default:
                    break;
            }
            return result;
             

        }
    }
}
