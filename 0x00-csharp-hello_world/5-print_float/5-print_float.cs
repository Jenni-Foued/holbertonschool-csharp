using System;

namespace _5_print_float
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 3.14159f;
            Console.WriteLine($"Float: {number.ToString("0.00")}");
        }
    }
}
