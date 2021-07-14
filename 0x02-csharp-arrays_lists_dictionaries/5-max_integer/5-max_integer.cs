using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            System.Console.WriteLine("List is empty");
            return(-1);
        }
        int max = int.MinValue;
        foreach (var integer in myList)
        {
            if (integer > max)
                max = integer;
        }
        return max;
    }
}
