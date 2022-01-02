using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class stringsorting
    {
        string []str = new string[10];
        string str2 = string.Empty;
        string temp2;
        string str4;
       
        static int temp = 0;
        static int temp1 = 0;
       
        string str3 = string.Empty;
        int n = 0;
       
        public void userinput()
        {
            
            Console.WriteLine("Enter the string");
            str2 = Console.ReadLine();
            for (int i = 0; i < str2.Length; i++)
            { 
                str[n] = str2[i].ToString();
                n++;
            }
            
             sortstring(str);
           
           
        }
        public void sortstring(string[] str)
        {

        
            for (int first = 0; first < str.Length; first++)
            {
                str3 = str[first].ToString();
                foreach (char ccc in str3)
                {
                    temp = (int)ccc;
                  
                }

                for (int last = 0; last < str.Length; last++)
                {

                    str4 = str[last].ToString();
                    foreach (char ccc in str4)
                    {
                        temp1 = (int)ccc;
                    }

                    if (temp < temp1)
                    {
                        temp2 = str[last].ToString();
                        str[last] = str[first].ToString();
                        str[first] = temp2;


                    }
                   
                }
                
            }
            for (int l = 0; l < str.Length; l++)
            {

                Console.Write(str[l]);
            }
           
        }
        static void Main(string[] args)
        {
            stringsorting obj = new stringsorting();
            obj.userinput();
            Console.Read();
        }
    }
}
