using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class removespacestring
    {
        string str = string.Empty;
        static string[] str2 = new string[20];
        static int i = 0;
        static int k = 0;
        public void input()
        {
            Console.WriteLine("Enter the first String to merge");
            str = Console.ReadLine();
           
            showoutput(str);
        }
        public void showoutput(string str)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j].ToString()!= " ")
                {
                    str2[k] = str[j].ToString();
                    k++;
                }
                  
                 
            }
            for (i = 0; i < str2.Length; i++)
            {
                Console.Write(str2[i]);
            }
        }
        static void Main()
        {
            removespacestring obj = new removespacestring();

            obj.input();

            Console.Read();
        }
    }

}
