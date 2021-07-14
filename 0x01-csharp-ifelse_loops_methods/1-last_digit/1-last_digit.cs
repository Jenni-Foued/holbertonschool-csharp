using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigit = number % 5;
        Console.Write($"The last digit of {number} is {lastDigit} and is ");
        if (lastDigit > 5)
            Console.WriteLine("greater than 5");
        else if (lastDigit == 0)
            Console.WriteLine("0");
        else
            Console.WriteLine("less than 6 and not 0");
    }
}
