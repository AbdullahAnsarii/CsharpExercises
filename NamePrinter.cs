using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string ans1 = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0} My name is C#, How old are you?", ans1 );
            int ans2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} good, As for me I was born in 2002 which makes me {1} years old", ans2, DateTime.Now.Year-2002 );

        }
    }
}
