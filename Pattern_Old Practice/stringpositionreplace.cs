using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class stringpositionreplace
    {
       static string str;
      string[]str1 = new string[50];
      string str2 = string.Empty;
      static int length1,length2=1;
        char ch;
        public string input()
        {
            Console.WriteLine("Enter the sring to replace the position:");
            str=Console.ReadLine();
            return str;
            
        }
       
        public void replacestring(string str)
        {
            int k = 0;
            length1=str.Length-1;
            for (int length = 0; length < str.Length-1; length++)
            {
                if (str[length].ToString() != " ")
                {
                    k += 1;

                }
            }
            k = k + 1;
            str1 = new string[k];
            k=0;
            for (int length = 0; length < str.Length - 1; length++)
            {
                if (str[length].ToString() != " ")
                {
                    str2 += str[length].ToString();
                    str1[k] = str[length].ToString();

                }
                else
                {
                    k = k + 1;
                }
            }
            k = k + 1;
            for (int i = 0; i < str2.Length; i++)
            {
                str1[k] = str2[i].ToString();
            }
           
          
        }

        public static void Main()
        {
            stringpositionreplace obj = new stringpositionreplace();
            str=obj.input();
           
            obj.replacestring(str);
            Console.ReadKey();

        }
    }
}
