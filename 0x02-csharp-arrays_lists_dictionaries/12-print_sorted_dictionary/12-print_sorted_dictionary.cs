using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        string[] arraykeys = myDict.Keys.ToArray();
        Array.Sort(arraykeys);
        for (var i = 0; i < arraykeys.Length; i++)
        {
            System.Console.WriteLine("{0}: {1}", arraykeys[i], myDict[arraykeys[i]]);
        }
    }
}
