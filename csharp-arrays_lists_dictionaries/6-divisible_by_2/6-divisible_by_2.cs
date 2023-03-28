using System;
using System.Collections.Generic;

    class List
    {
        public static List<bool> DivisibleBy2(List<int> myList)
        {
            List<bool> resultList = new List<bool>();
            for (int pos = 0; pos < myList.Count; pos++)
            {
                if (myList[pos] % 2 == 0)
                {
                    resultList.Add(true);
                }
                else
                {
                    resultList.Add(false);
                }
            }
            return (resultList);
        }
    }
