using System;

class List
{
    public static System.Collections.Generic.List<int> DeleteAt(System.Collections.Generic.List<int> myList, int index)
    {
        myList.Remove(myList[index]);
        return myList;
    }
}
