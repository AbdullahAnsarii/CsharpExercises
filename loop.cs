using System;

namespace loopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers Machine!!!");
            for (int i = 1; i <= 100; i++)
            {
                //Console.WriteLine(i);
                
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                //i++;
            }
            //PAHAAR!!!
            Console.WriteLine("\n -------PAHAAR-------");
            string eggs = "0";
            int counter = 1;
            do
            {
                Console.WriteLine(eggs);
                counter ++;
                eggs = eggs + "0";
            } while (counter <= 10);
            Random rnd = new Random();
            double k = 0;
            k = rnd.NextDouble();
            Console.WriteLine(k);

            //Arrays

            int[] array = { 1, 2, 3, 4, 5 };
            int[] emptyArray = new int[5];
            Console.WriteLine(array[2]);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("for se " + i);
            }
            foreach (var item in array)
            {
                Console.WriteLine("foreach se " + item);

            }


        
        }
    }
}