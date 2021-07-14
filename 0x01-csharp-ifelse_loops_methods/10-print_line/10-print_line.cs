using System;

class Line
{
    public static void PrintLine(int length)
    {
        while (length > 0)
        {
            Console.Write('_');
            length--;
        }
        Console.WriteLine("");
    }
}
