using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> diffElementsList = new List<int>();

        foreach (var number in list1)
        {
            if (! list2.Contains(number))
                diffElementsList.Add(number);
        }

        foreach (var number in list2)
        {
            if (! list1.Contains(number))
                diffElementsList.Add(number);
        }

        diffElementsList.Sort();
        return diffElementsList;
    }
}
