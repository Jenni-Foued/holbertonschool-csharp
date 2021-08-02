using System;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        return Object.ReferenceEquals(obj.GetType(), typeof(int));
    }
}
