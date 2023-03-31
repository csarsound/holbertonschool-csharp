using System;
using System.Collection.Generic;

namespace _1_common_elements
{
    class List
    {
        public static List<int> CommonElements(List<int> list1, List<int> list2)
        {
            List<int> commonElemenList = new List<int>();

            if (list1.Count != 0 && list2.Count != 0)
            {
                list1.Sort();
                list2.Sort();

                foreach (var element1 in list1)
                {
                    foreach (var element2 in list2)
                    {
                        if (element2 == element1)
                        {
                            commonElementList.Add(element2);
                            break;
                        }
                    }
                }
            }
            return (commonElementList);
        }
    }
}
