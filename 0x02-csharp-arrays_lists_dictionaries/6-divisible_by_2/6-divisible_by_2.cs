using System;

class List
{
    public static System.Collections.Generic.List<bool> DivisibleBy2(System.Collections.Generic.List<int> myList)
    {
        System.Collections.Generic.List<bool> divBy2 = new System.Collections.Generic.List<bool>();
        if (myList.Count > 0)
            foreach (var number in myList)
            {
                if (number % 2 == 0)
                    divBy2.Add(true);
                else
                    divBy2.Add(false);
            }
        return divBy2;
    }
}
