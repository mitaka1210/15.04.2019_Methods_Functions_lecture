using System;

namespace _10._RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            int number = int.Parse(Console.ReadLine());

            int count =0;

            for (int i = 0; i < number; i++)
            {
                Console.Write(name);
                count++;
            }
            Console.WriteLine();
            return;
            
        }
    }
}
