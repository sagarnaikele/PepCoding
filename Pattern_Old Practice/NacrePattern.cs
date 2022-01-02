using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class NacrePattern
    {
        string str = string.Empty;
        int count = 0,count1,count2;
        int sp=0;
        int sp1=0 ;
        int flag = 0;
        int flag1 = 0;
        public void input()
        {
            Console.Write("Enter the Input:=");
            str = Console.ReadLine();
            printpattern();
           
        }
        public void printpattern()
        {
            sp = str.Length - 3;
            for (int i = 1; i <=str.Length; i++)
            {
                 //if(str.Length==count1)
                 //{
                    
                 //    sp1=sp-1;
                 //    count1--;

                 //}
                
                for (int space = sp1; space <  sp; space++)
                {
                    Console.Write("$");
                }
               
                
                for (int cell = 0; cell < 2 * i - 1; cell++)
                {
                    if (flag1 != 1)
                    {

                        printing();
                    }
                    else
                    {
                        int row=i;
                    cellprint:
                        if ( row<=count2+1)
                        {
                            printing();
                            row++;
                            goto cellprint;

                        }
                   count2 = count2-1;
                    break;
                    }
                }
                Console.WriteLine();
                if (str.Length == count1)
                {
                    flag1 = 1;
                    count2 = count1;
                }
                else
                {
                    count1 = 0;
                }
                   
              
          
               
           
        }
           
        }
        public void printing()
        {
            if (flag == 0)
            {

                Console.Write(str[count]);
                count++;
                count1++;
                if (count == str.Length)
                {
                    flag = 1;
                    count--;
                }
            }
            else
            {
                count--;
                Console.Write(str[count]);
                count1++;
                if (count == 0)
                {
                    flag = 0;
                    count++;
                    
                }
            }

           

        }
        static void Main()
        {
            NacrePattern obj = new NacrePattern();
            obj.input();
            Console.ReadKey();
        }
    }

}
