using System;

namespace nestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x == y)
                Console.WriteLine("x=y");
            else if (x != y)
            {
                if (x < y)
                    Console.WriteLine("x<y");

                else if (x > y)
                    Console.WriteLine("x>y"); 

            }
            
        }
    }
}
