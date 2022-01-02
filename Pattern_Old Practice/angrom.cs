using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class angrom
    {
        string str1 = string.Empty;
        string str2 = string.Empty;
        
        int flag1 = 0;
        int count = 0;
        int count1=0;
        int flag = 0;
        string str4 = string.Empty;
        string str5 = string.Empty;
        string str6 = string.Empty;
        public void amaron()
        {
            Console.WriteLine("Enter the string:=");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the string:=");
            str2 = Console.ReadLine();
            for (int k = 0; k < str1.Length; k++)
            {
                str4 = str1[k].ToString();
                for (int i = 0; i < str1.Length; i++)
                {
                    str5 = str1[i].ToString();
                    if (str5==str4)
                    {
                        count++;
                       
                    }
                   
                }
               
                for (int j = 0; j < str2.Length; j++)
                {
                    str6 = str2[j].ToString();
                    if (str4==str6)
                    {
                        flag = 1;
                        count1++;
                    }
                   
                }
                if (count != count1 || flag == 0)
                {
                    flag1 = 1;
                   // break;
                }
                if (flag1==1)
                {
                    flag = 0;
                    break;
                }
                count = 0;
                count1 = 0;
            }
            if (flag == 0)
            {
                Console.Write("this is not angrom");
            }
            else
            {
                Console.Write("this is angrom");
            }
           
        }
        static void Main()
        {
            angrom obj = new angrom();
            obj.amaron();
            Console.Read();
        }
    }
}
