using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int counter = 0;
        
        foreach (var item in myLList)
        {
            if (item == value)
                return counter;
            counter++;
        }
        return -1 ;
    }
}
