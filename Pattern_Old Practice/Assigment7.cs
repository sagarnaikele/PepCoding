using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Assigment7
    {
        string str, str1, str2,str3;
   
        int flag = 1;
        Boolean check = false;
        int j ;
        int l = 0;
        public void userinput()
        {
            Console.WriteLine("Enter the String:=");
            str = Console.ReadLine();
            checkstring(str);
        }
        public void checkstring(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() != " "&&str[i].ToString()!=".")
                {
                    str1 += str[i].ToString();
                }
                else
                {
                    for (j = str1.Length-1; j >= 0; j--)
                    {
                        if (str1[j] != null)
                        {
                            str2 += str1[j].ToString();
                        }
                    }
                    j = str2.Length;
                    str1 = string.Empty;
                    for (int k = 0; k <str.Length; k++)
                    {
                       
                            if (str[k].ToString() != " "&&str[k].ToString()!=".")
                            {
                                str1 += str[k].ToString();
                            }
                            
                      
                    
                        else
                        {

                            if (str1.Length == str2.Length)
                            {

                                for (l = 0; l < str1.Length; l++)
                                {
                                    if (str1[l].ToString() == str2[l].ToString())
                                    {

                                        flag = 1;

                                    }
                                    else
                                    {
                                        flag = 0;
                                        l = 0;
                                        str1 = string.Empty;
                                        break;

                                    }
                                }
                                if (flag == 1)
                                {
                                    if (str2.Length > 2)
                                    {
                                        Console.WriteLine("Value found and that value is:" + str2);
                                        check = true;
                                    }
                                    str1 = string.Empty;

                                    flag = 0;
                                }
                            }
                            else
                            {
                                str1 = string.Empty;

                            }
                        }
                    }
                    str1 = string.Empty;
                    str2=string.Empty;
                }
                
            }
            if (check == false)
            {
                Console.Write("Sorry No Reverse Word found in this string");
            }
        }
        public static void Main()
        {
            Assigment7 obj = new Assigment7();
            obj.userinput();
            Console.ReadLine();
        }

    }
}
