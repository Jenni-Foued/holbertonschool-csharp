using System;
using System.Linq;
namespace Text
{
    /// <summary>Str class contains one methode UniqueChar().</summary>
    public class Str
    {
        /// <summary>A method that returns the index of the first non-repeating character of a string.</summary>
        /// <param name="s">String to verify.</param>
        /// <return>Index of first non-repeating character or -1 if there is no non-repeating character.</return>
        public static int UniqueChar(string s)
        {
            int freq;
            int i = 0;
            for (; i < s.Length;i++)
            {
                freq = s.Count(f => (f == s[i]));
                if (freq == 1)
                    return i;
            }
            return -1;
        }
    }
}
