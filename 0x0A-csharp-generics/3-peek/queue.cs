using System;

/// <summary>
/// Create custom generic class Queue.
/// </summary>
class Queue<T>
{
    public Node head { get; set; }
    public Node tail { get; set; }

    public int count;

    /// <summary>
    /// Returns the value of the first node.
    /// </summary>
    public T Peek()
    {
        if(head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }
    /// <summary>
    /// Removes the first node in the queue and returns its value.
    ///<returns>Returns the value of the removed node.</returns>
    /// </summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T currentHead = head.value;
        head = head.next;
        count -= 1;
        return (currentHead);
    }

    /// <summary>
    /// Creates a new Node and adds it to the end of the queue.
    /// </summary>
    public void Enqueue(T value)
    {
        Node n = new Node(value);
        if (count == 0)
        {
            head = n;
            tail = n;
            n.next = null;
        }
        else
        {
            tail.next = n;
            tail = n;
        }
        count++;
    }

    /// <summary>
    /// Returns the Queue’s type.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    public int Count()
    {
        return this.count;
    }

    /// <summary>
    /// Node of the queue.
    /// </summary>
    public class Node
    {
        public T value { get; set; }

        public Node next { get; set; }

        /// <summary>
        /// Node's constructor.
        /// </summary>
        /// <param name="value">The Node's value.</param>
        public Node(T value)
        {
            this.value = value;
        }
    }
}
