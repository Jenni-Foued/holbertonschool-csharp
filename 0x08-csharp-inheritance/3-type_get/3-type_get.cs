using System;
using System.Reflection;
/// <summary>
/// Obj class contains one function Print().
/// </summary>
class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">object to use.</param>
    public static void Print(object myObj)
    {
        PropertyInfo[] props = myObj.GetType().GetProperties();
        MethodInfo[] meths = myObj.GetType().GetMethods();

        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach(var prop in props)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (var meth in meths)
        {
            Console.WriteLine(meth.Name);
        }
    }
}
