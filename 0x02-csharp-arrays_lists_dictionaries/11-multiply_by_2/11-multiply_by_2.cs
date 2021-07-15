using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        for (var i = 0; i < myDict.Count; i++)
            myDictionary[myDict.ElementAt(i).Key] = myDict.ElementAt(i).Value * 2;

        return myDictionary;
    }
}
