using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> tmp = myLList.First;
		while (tmp != null)
		{
			if (n < tmp.Value)
			{
				return myLList.AddBefore(tmp, n);
			}
			tmp = tmp.Next;
		}
		return myLList.AddLast(n);
	}
}
