using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int counter = 0;

        foreach (var item in myLList)
        {
            if (counter == n)
                return item;
            counter++;
        }

        return 0;
    }
}
