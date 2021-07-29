using System;

namespace Text
{
    /// <summary>Str class contains one function IsPalindrome.</summary>
    public class Str
    {
        /// <summary>A method that returns True if a string is a palindrome or False if it’s not.</summary>
        /// <param name="s">A String.</param>
        /// <return>True or False.</return>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return true;
            s = s.ToUpper();
            int j = s.Length - 1;
            int i = 0;
            while (i < j)
            {
                var matchj = s[j].ToString().IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) == -1;
                var matchi = s[i].ToString().IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) == -1;
                if(matchj)
                    j--;
                else if (matchi)
                    i++;
                else
                {
                    if(s[i] != s[j])
                        return false;
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}
