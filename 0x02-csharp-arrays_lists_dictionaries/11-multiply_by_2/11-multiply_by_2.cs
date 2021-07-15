using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> tuple in myDict)
            myDictionary[tuple.Key] = tuple.Value * 2;

        return myDictionary;
    }
}
