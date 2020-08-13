using System;

namespace evenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Even/Odd Calculator----------------");
            Console.WriteLine("Please Enter the numer:  ");
            int input = int.Parse(Console.ReadLine());
            int div = 0;
            div = input % 2;
            if (div == 0)
            {
                Console.WriteLine("The number is even!!!");

            }
            else
            {
                Console.WriteLine("The number is odd!!!");
            }

        }
    }
}
