using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index >= array.Length || index < 0)
            Console.WriteLine("Index out of range");
        else
            array[index] = n;
        return array;
    }
}
