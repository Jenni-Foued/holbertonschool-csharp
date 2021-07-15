using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int listSum = 0;

        foreach (var item in myLList)
        {
            listSum += item;
        }
        return listSum;
    }
}
