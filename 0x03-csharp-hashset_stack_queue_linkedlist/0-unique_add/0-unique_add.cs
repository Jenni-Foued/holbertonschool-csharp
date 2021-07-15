using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sumDistinct = 0;
        HashSet<int> distinct = new HashSet<int>();

        foreach (var number in myList)
        {
            distinct.Add(number);
        }

        foreach (var number in distinct)
        {
            sumDistinct += number;
        }
        return sumDistinct;
    }
}
