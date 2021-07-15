using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }
        LinkedListNode<int> node = myLList.First;
        while (node.Next != null)
        {
            if (n <= node.Value)
            {
                myLList.AddBefore(node, n);
                break;
            }
            else
                node = node.Next;
        }

        return node.Previous;
    }
}
