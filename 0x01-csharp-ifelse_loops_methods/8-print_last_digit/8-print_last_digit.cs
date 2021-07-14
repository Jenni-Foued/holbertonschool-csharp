using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit;
        lastDigit  = Math.Abs(number % 10);
        Console.Write(lastDigit);
        return (lastDigit);
    }
}
