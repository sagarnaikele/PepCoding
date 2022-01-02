using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class removeduplicatestring
    {
        static void Main(string[] args)
        {
            string str =string.Empty;

            string[] str1 = new string[10];
            string[] str2 = new string[10];
           

          
            int count = 0;
            int[] a = new int[10];
            int flag = 0; int i = 0, k = 0, l = 0, j = 0, x = 0;
            Console.WriteLine("Enter the string to find occurance");
            str = Console.ReadLine();
            for (i = 0; i < str.Length; i++)
            {
                str1[j] = str[i].ToString();
                j++;
            }

            for (i = 0; i < str.Length; i++)
            {
                for (j = 0; j < str1.Length; j++)
                {
                    string strr = str[i].ToString();
                    if (strr.ToUpper() == str1[j].ToUpper())
                    {
                        count++;

                    }


                }
                if (i == 0)
                {
                    str2[x] = str[i].ToString();
                   
                    x++;
                    a[l] = count;
                    l++;
                    
                }
                else
                {


                    for (int n = 0; n < str2.Length; n++)
                    {
                        if (str2[n] != null)
                        {
                            if (str[i].ToString() == str2[n].ToString())
                            {

                                flag = 1;
                                break;
                            }
                        }

                    }
                    if (flag == 0)
                    {
                        str2[x] = str[i].ToString();
                        x++;
                     
                        a[l] = count;
                        l++;


                    }

                }

                k++;
                count = 0;
                flag = 0;
            }
            Console.WriteLine();
            for (int n = 0; n < str2.Length; n++)
            {

                if (str2[n] != null)
                {
                    Console.WriteLine("occurance of" + str2[n] + "in this string is:=" + a[n]);
                    Console.WriteLine();
                }
            }

            Console.Read();
        }
    }
}
