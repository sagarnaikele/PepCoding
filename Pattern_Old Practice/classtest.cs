using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{

    class classtest
    {
        static string str, str1;

        static int i, j;
        static void Main()
        {
            Console.Write("Enter the string");
            str = Console.ReadLine();
            for (i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() != " ")
                {
                    str1 += str[i].ToString();
                }
                else
                {
                    j = 0;
                    Console.WriteLine("value is:" + str1[0].ToString());
                    str1 = string.Empty;
                }
            }
            for (i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i]);
            }
            Console.ReadLine();
        }
    }
}
