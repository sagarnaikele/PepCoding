using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class mergestring
    {
        static string str = string.Empty;
        static string str1 = string.Empty;
        static string[] str2 = new string[20];
        static int i = 0;
        static int k = 0;
        public void  input()
        {
            Console.WriteLine("Enter the first String to merge");
            str = Console.ReadLine();
            Console.WriteLine("Enter the second string to merge");
            str1 = Console.ReadLine();
            showoutput(str, str1);
        }
        public void showoutput(string str, string str1)
        {
            for (int j = 0; j < str.Length; j++)
            {
                for (i = j; i <=str1.Length; i++)
                {
                    str2[k] = str[j].ToString();
                    k++;
                    str2[k] = str1[j].ToString();
                    break;
                }
                k++;
            }
            for (i = 0; i < str2.Length; i++)
            {
                Console.WriteLine(str2[i]);
            }
        }
        static void Main()
        {
            mergestring obj = new mergestring();
            
           obj.input();
           
            Console.Read();
        }
    }

}
