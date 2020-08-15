using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = string.Format("Date is {0:yyyy MMMM dddd HH mm ss tt}", myDate);
            Console.WriteLine(formattedDate);

            DateTime reqDate = DateTime.Now;
            string firstFormat = string.Format("{0:dd-MM-yyyy HH:mm:ss}", reqDate);
            Console.WriteLine(firstFormat);

            string secondFormat = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", reqDate);
            Console.WriteLine(secondFormat);

            string thirdFormat = string.Format("{0: 'Day' dddd \n 'Month' MMMM \n 'Year' yyyy}", reqDate);
            Console.WriteLine(thirdFormat);


            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (x < y)
            {
                Console.WriteLine("y is greater than x");
            }

            Console.WriteLine("Do you love me? Y or N");
            string pn = Console.ReadLine();

            switch (pn)
            {
                case "Y": Console.WriteLine("Thank you"); break;
                case "N": Console.WriteLine("F you"); break;
                default: Console.WriteLine("Sahi likho"); break;
            }
            
            
            
            

            

        }
    }

}
