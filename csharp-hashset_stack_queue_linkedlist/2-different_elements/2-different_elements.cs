using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> DifferentElementList = new List<int>();

            list1.Sort();
            list2.Sort();

            foreach (var element in list1)
            {
	        if (!list2.Contains(element))
			DifferentElementList.Add(element);
	    }

	    foreach (var element in list2)
	    {
		if (!list1.Contains(element))
			DifferentElementList.Add(element);
	    }

		DifferentElementList.Sort();

		return (DifferentElementList);
	}
}
