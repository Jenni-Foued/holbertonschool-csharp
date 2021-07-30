using System;

namespace Text
{
    /// <summary>Str class contains one methode CamelCase().</summary>
    public class Str
    {
        /// <summary>A method that determines how many words are in a string.</summary>
        /// <param name="s">String to verify.</param>
        /// <return>Number of words in the string s.</return>
        public static int CamelCase(string s)
        {
            if (s.Length == 0 || s == null)
                return 0;
            int counter = 1;
            foreach (char character in s)
            {
                if (character >= 'A' && character <= 'Z')
                    counter++;
            }
            return counter;
        }
    }
}
