using System;

namespace _07._MathPower
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int power = int.Parse(Console.ReadLine());
            double result = RaisePower(number, power);
            Console.WriteLine(result);
            
        }

        public static double RaisePower(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;

        }
    }
}
