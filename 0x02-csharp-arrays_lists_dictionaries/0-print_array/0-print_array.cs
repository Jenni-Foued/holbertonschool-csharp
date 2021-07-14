using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int i = 0;
        if (size < 0)
        {
            Console.Write("Size cannot be negative");
            return null;
        }
        int[] newArray = new int[size];
        if (size == 0)
            Console.WriteLine();
        else
        {
            for (; i < size - 1; i++)
            {
                newArray[i] = i;
                Console.Write($"{i} ");
            }
            newArray[i] = i;
            Console.WriteLine($"{i}");
        }
        return newArray;
    }
}
