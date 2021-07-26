class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            System.Console.WriteLine(a + " / " + b + " = " + result);
        }
    }
}
