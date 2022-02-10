using System;
using System.Collections.Generic;
using System.Linq;

namespace HashMapReqired
{
    public class HashMapGetCommonElement
    {
        public static void Main()
        {

        }

        public char GetCommon1(int n1, int n2)
        {
            if (n1 == n2)
            {
                return n1;
            }
            Dictionary<int, int> n1COunt = new Dictionary<int, int>();
            Dictionary<int, int> n2COunt = new Dictionary<int, int>();

            while (n1 != 0 && n2 != 0)
            {
                int temp1 = n1 % 10;
                int temp2 = n2 % 10;
                if (n1COunt.ContainsKey(temp1))
                {

                }


            }

            var res = charCount.Max();
            return res.Key;

        }
    }
}