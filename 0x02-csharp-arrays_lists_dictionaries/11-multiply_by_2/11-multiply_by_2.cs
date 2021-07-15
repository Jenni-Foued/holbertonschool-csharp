using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        foreach (var item in myDict)
            item.Value *= 2;

        return myDict;
    }
}
