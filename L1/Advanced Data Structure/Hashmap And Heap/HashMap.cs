using System;
using System.Collections.Generic;
using System.Linq;

namespace HashMapReqired
{
    public class HashMap
    {
        public static void Main()
        {

        }

        public char FindHighestFeqChar(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return ' ';
            }
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount.ContainsKey(str[i]))
                    charCount[str[i]] = charCount[str[i]] + 1;
                else
                    charCount[str[i]] = 1;
            }

            var res = charCount.Max();
            return res.Key;

        }
    }
}