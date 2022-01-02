using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class CircularPrime
    {
        string no;
        int []arr;
        int  temp;
       
        public void input()
        {
            Console.WriteLine("Enter the no to check ciruclar prime");
            no = Console.ReadLine();
            arr=new int[no.Length];
            checkprime(Convert.ToInt32(no));
           
            string str1 = string.Empty;
            for (int i = 0; i < no.Length;i++)
            {
                str1 = no[i].ToString();
               
               // ch[i] = no[i];
                //int myno = Convert.ToInt32(ch[i]);

                arr[i] = Convert.ToInt32(str1);
            }
            Console.WriteLine("Now Checking Combination of Prime");
            Console.WriteLine();
            printpattern();
        }
        public void printpattern()
        {
            for (int j = 0; j < no.Length; j++)
            {

                for(int i=0;i<no.Length-1;i++)
                {
                    
                    temp = arr[i];
	                 arr[i] = arr[i+1];
	                arr[i+1] = temp;
                    string strr1 = string.Empty;
                    temp = 0;
                    for(int k=0;k<arr.Length;k++)
                    {
                        strr1+= arr[k].ToString();
                        
                         
                        
                    }
                    temp= Convert.ToInt32(strr1);
                    checkprime(temp);
                    Console.WriteLine();
                }
            }
        }
        public void checkprime(int temp)
        {
            int count=0;
           
            for (int no1 = 2; no1 < temp / 2; no1++)
            {
                if (temp % no1 == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 1)
            {
                Console.WriteLine(temp + "is not Prime");
               
                
            }
            else
            {
                Console.WriteLine("Prime no is:" + temp);
            }
        }
        static void Main()
        {
            CircularPrime obj=new CircularPrime();
            obj.input();
            Console.ReadLine();
        }
    

    }
}
