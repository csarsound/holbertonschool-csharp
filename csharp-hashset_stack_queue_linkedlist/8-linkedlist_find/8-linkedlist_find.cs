using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;

        if (!myLList.Contains(value))
            return (-1);

        foreach (var item in myLList)
        {
            if (item == value)
                break;

            index++;
        }

        return (index);
    }
}
