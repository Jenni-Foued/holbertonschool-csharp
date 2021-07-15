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
        while (node != null)
        {
            if (n <= node.Value)
            {
                myLList.AddBefore(node, n);
                return node.Previous;
            }
            if (node.Next != null)
                node = node.Next;
            else
                break;
        }

        myLList.AddAfter(node, n);
        return node.Next;
    }
}
