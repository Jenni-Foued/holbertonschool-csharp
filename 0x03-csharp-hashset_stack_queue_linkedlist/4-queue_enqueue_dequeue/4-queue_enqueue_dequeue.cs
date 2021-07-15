using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int itemsCount = aQueue.Count;

        System.Console.WriteLine("Number of items: {0}", itemsCount);

        if (itemsCount > 0)
            System.Console.WriteLine("First item: {0}", aQueue.Peek());
        else
            System.Console.WriteLine("Queue is empty");

        System.Console.WriteLine("Queue contains \"{1}\": {0}", aQueue.Contains(search), search);

        while (aQueue.Contains(search))
        {
            aQueue.Dequeue();
        }

        aQueue.Enqueue(newItem);

        return aQueue;
    }
}
