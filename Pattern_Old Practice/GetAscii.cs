using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class GetAscii
    {
        static void Main()
        {
            string[] str = new string[2] { "a", "b" };
            int temp;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str[i].ToString();
                foreach (char ccc in str1)
                {
                    temp = (int)ccc;
                    Console.WriteLine(temp);
                }
            }
            Console.Read();
        }
    }
}
