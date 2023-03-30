using System;
using System.Collections.Generic;

class Dictionary
{
    public static void BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> bestScore;

        if (myList.count == 0 || myList == null)
            return ("None");

        bestScore = myList.First();
        foreach (KeyValuePair<string, int> element in myList)
        {
            if (element.Value > bestScore.Value)
            {
                bestScore = element;
            }
        }
        return (bestScore.Key);
    }
}
