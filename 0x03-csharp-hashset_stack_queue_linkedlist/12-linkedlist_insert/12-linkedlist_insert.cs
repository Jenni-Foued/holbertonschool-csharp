using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
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
