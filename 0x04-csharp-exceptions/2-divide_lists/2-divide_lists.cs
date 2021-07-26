using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                result.Add(list1[i] / list2[i]);
            }
            catch (System.DivideByZeroException)
            {
                System.Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Out of range");
            }
        }
        return result;
    }
}
