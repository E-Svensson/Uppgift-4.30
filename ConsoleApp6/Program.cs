using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många X på grupp?: "); int Xantal = int.Parse(Console.ReadLine());
            Console.Write("Hur många O på grupp?: "); int Oantal = int.Parse(Console.ReadLine());
            Console.Write("Hur många grupper av O?: "); int Ogrupper = int.Parse(Console.ReadLine());
            Console.Write("Hur många rader?: "); int Rader = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < Rader; i++)
            {

                for (int X = 0; X < Xantal; X++)
                {
                    Console.Write("X");
                }

                for (int j = 0; j < Ogrupper; j++)
                {

                    Console.Write("-");

                    for (int O = 0; O < Oantal; O++)
                    {
                        Console.Write("O");
                    }

                    Console.Write("-");

                    for (int X = 0; X < Xantal; X++)
                    {
                        Console.Write("X");
                    }

                }

                Console.WriteLine();

            }
        }
    }
}
