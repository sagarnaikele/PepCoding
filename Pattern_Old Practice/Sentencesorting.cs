using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern 
{
    class Sentencesorting
    {
        int i=0, j=0, k=0;
        string[] str1;
        string str = string.Empty;
        string temp2;
        string str4;
      
        static int temp = 0;
        static int temp1 = 0;
        int sum,sum1,sum2;
        string str3 = string.Empty;
        string str5=string.Empty;
        string str6=string.Empty;
        int n = 0;
       
        public void userinput()
        {
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            
            for (i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() != " ")
                {
                   
                    
                }

                else
                {
                   
                    temp1=temp1+1;
                    
                }
               
            } 
            temp1 = temp1 + 1;
            str1 = new string[temp1];
            temp1=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() != " ")
                {
                    temp2 += str[i].ToString();
                }
                else
                {
                    str1[temp1] = temp2+" ";
                  
                    temp2 = string.Empty;
                    temp1 = temp1 + 1;
                }
            }
            
            str1[temp1]=temp2+" ";
           
            sortstring();
        }
        public void  sortstring()
        {
        
            for (int first = 0; first < str1.Length; first++)
            {
                //if (str1[first].ToString() != " ")
                //{
                sum = 0;
                    str3 = str1[first].ToString();
               // }
              
               
                   
                    
                    for(int l=0;l<str3.Length;l++)
                    {
                        char ccc = str3[l];
                        temp = (int)ccc;
                        sum=sum+temp;
                    }
                

                for (int last = 0; last < str1.Length; last++)
                {
                    sum1 = 0;
                    str4 = str1[last].ToString();
                    for (int l = 0; l < str4.Length; l++)
                    {
                        char cc = str4[l];
                        temp = (int)cc;
                        sum1 = sum1 + temp;
                    }

                    if (sum < sum1)
                    {
                        
                        temp2 = str1[first].ToString();
                        str1[first] = str1[last].ToString();
                        str1[last] = temp2;

                            
                        }


                    }

                }
            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i].ToString());
            }
       
        }
        public static void Main()
        {
            Sentencesorting obj = new Sentencesorting();
            obj.userinput();
            Console.ReadLine();
        }

    }
}
