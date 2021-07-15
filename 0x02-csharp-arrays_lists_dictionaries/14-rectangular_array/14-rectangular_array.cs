using System;

class Program
{
    static void Main(string[] args)
    {
        int [,] myArray = new int[5,5];
        int i = 0;
        int y;

        myArray[2,2] = 1;
        for (; i < 5; i++)
        {
            for (y = 0; y < 4; y++)
            {
                System.Console.Write("{0} ", myArray[i,y]);
            }
            System.Console.WriteLine("{0}", myArray[i,y]);
        }
    }
}
