using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int i = 0;
        string emptySpaces = "";

        if (length <= 0)
            Console.WriteLine();
        for (; i < length; i++)
        {
            Console.WriteLine(emptySpaces + "\\");
            emptySpaces += " ";
        }
    }
}
