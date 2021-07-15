using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int maxScore = 0;
        string studentName = "None";

        foreach (var item in myList)
        {
            if (maxScore <= item.Value)
            {
                maxScore = item.Value;
                studentName = item.Key;
            }
        }
            return studentName;
    }
}
