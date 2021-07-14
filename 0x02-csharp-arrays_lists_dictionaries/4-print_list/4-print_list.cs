using System;

class List
{
    public static System.Collections.Generic.List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            System.Console.WriteLine("Size cannot be negative");
            return null;
        }

        System.Collections.Generic.List<int> numbers = new System.Collections.Generic.List<int>();
        if ( size > 0)
        {    
            int i = 0;
        
            for (; i < size - 1; i++)
            {
                numbers.Add(i);
                System.Console.Write("{0} ",i);
            }

            numbers.Add(i);
            System.Console.WriteLine(i);
        }
        return numbers;
    }
}
