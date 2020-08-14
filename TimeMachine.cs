using System;

namespace TimeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Time Machine-------------");
            Console.WriteLine("Enter the day: ");
            int xday = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month: ");
            int xmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year: ");
            int xyear = int.Parse(Console.ReadLine());
            DateTime fday = new DateTime(xyear, xmonth, xday);
            Console.WriteLine("This day should be {0}", fday.DayOfWeek);




        }
    }
}
