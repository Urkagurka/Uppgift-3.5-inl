using System;

namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 tal");
            Console.WriteLine("Tal 1");
            int TAL1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tal 2");
            int TAL2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            int VAL = int.Parse(Console.ReadLine());

            if (VAL == 1)
            {
                Console.WriteLine("Svaret blir: " + (TAL1 + TAL2));
            }
            else if (VAL == 2)
            {
                Console.WriteLine("Svaret blir: " + (TAL1 - TAL2));
            }
            else if (VAL == 3)
            {
                Console.WriteLine("Svaret blir: " + (TAL1 * TAL2));
            }
            else if (VAL == 4)
            {
                Console.WriteLine("Svaret blir: " + (TAL1 / TAL2));
            }
            else if (VAL >= 5)
            {
                Console.WriteLine("Det räknesättet finns inte");
            }
            Console.ReadKey();
        }
    }
}