using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        try
        {
            for (; i < n; i++)
                System.Console.WriteLine(myList[i]);
            return i;
        }
        catch (System.Exception)
        {
            
            return i;
        }
    }
}
