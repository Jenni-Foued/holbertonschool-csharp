using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int counter = 0;

        foreach (var item in myLList)
            counter++;

        return counter;
    }
}
