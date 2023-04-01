using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int numberElements = 0;

        foreach (var item in myLList)
            numberElements = numberElements + 1;

        return (numberElements);
    }
}
