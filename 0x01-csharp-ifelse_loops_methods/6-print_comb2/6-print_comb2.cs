using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i < 9; i++)
                for (j = i + 1; j <= 9; j++)
                    if (i < 8)
                        Console.Write($"{i}{j}, ");
                    else
                        Console.WriteLine($"{i}{j}");
        }
    }
}
