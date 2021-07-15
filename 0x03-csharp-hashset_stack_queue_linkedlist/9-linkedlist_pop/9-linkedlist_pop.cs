using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int firstItem = myLList.First.Value;

        myLList.RemoveFirst();

        return firstItem;
    }
}
