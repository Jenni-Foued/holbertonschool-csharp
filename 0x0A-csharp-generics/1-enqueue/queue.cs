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
        private T value { get; set; }

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
