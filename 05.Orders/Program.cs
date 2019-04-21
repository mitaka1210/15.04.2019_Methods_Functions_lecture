using System;

namespace _05.Orders
{
    class Program
    {

        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            int number = int.Parse(Console.ReadLine());

            Product(name, number);

        }

        public static void Product(string name, int number)
        {
            if (name == "coffee")
            {
                double price = number * 1.50;
                Console.WriteLine($"{price:F2}");
            }
            else if (name == "water")
            {

                double price = number * 1.00;
                Console.WriteLine($"{price:F2}");
            }
            else if (name == "coke")
            {
                double price = number * 1.40;
                Console.WriteLine($"{price:F2}");
            }
            else if (name == "snacks")
            {
                double price = number * 2.00;
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
