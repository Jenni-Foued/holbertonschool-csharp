using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int itemsCount = aStack.Count;

        System.Console.WriteLine("Number of items: {0}", itemsCount);

        if (itemsCount > 0)
            System.Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            System.Console.WriteLine("Stack is empty");
        
        System.Console.WriteLine("Stack contains \"{1}\": {0}", aStack.Contains(search), search);
        
        while (aStack.Contains(search))
        {
            aStack.Pop();
        }

        aStack.Push(newItem);

        return aStack;
    }
}
