using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
            System.Console.WriteLine("Index is out of range");
        else
            myList.Remove(myList[index]);
        return myList;
    }
}
