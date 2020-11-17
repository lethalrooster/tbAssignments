using System;

namespace tbAssignment5
{
    class Program
    {
        static void sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;


            Console.WriteLine("Vill du summera två tal?");
            string input = Console.ReadLine();
            if (input.CompareTo("ja") == 0)
            {
                Console.WriteLine("Skriv in två värden som ska summeras");
                int x = Console.ReadLine();
                int y = Console.ReadLine();
            }
                
            float sum = sum(x, y);
        }
    }
}
