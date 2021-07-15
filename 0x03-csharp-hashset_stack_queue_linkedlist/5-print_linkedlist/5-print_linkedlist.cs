using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLinkedList = new LinkedList<int>();

        for (var i = 0; i < size; i++)
        {
            myLinkedList.AddLast(i);
            System.Console.WriteLine(i);
        }
        
        return (myLinkedList);
    }
}
