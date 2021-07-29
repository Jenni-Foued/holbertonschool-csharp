using System;

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
            int occurence = 0;
            if (s != null && s.Length != 0)
            {
                for (int i = 0; i< s.Length;i++)
                {
                    for (int j =0; j< s.Length;j++)
                    {
                        if (s[i] == s[j])
                            occurence += 1;
                    }
                    if (occurence == 1)
                        return i; 
                }
            }
            return -1;
        }
    }
}
